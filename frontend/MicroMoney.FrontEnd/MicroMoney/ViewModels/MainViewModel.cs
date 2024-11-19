using CommunityToolkit.Mvvm.ComponentModel;
using MicroMoney.Services.Abstract;
using MicroMoney.ViewModels.LeftTabs;
using MicroMoney.ViewModels.RightTabs;
using MicroMoney.ViewModels.RightTabs.Panels.Add;
using MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet;
using MicroMoney.Views.Converters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;


namespace MicroMoney.ViewModels;

public partial class MainViewModel : ViewModelBase, IUiService
{
    [ObservableProperty]
    private ViewModelBase? model;
    [ObservableProperty]
    private double modelOpacity;
    [ObservableProperty]
    private double mainViewOpacity;
    [ObservableProperty]
    private bool mainViewEnabled;
    [ObservableProperty]
    private bool modelEnabled;
    [ObservableProperty]
    private string? treePath;
    [ObservableProperty]
    private ObservableCollection<LeftTabsViewModel> leftTabs;
    [ObservableProperty]
    private int leftTabsSelectedIndex;
    [ObservableProperty]
    private LeftTabsViewModel leftSelectedTab;
    [ObservableProperty]
    private ObservableCollection<RightTabsViewModel> rightTabs;
    [ObservableProperty]
    private int rightTabsSelectedIndex;
    [ObservableProperty]
    private RightTabsViewModel rightSelectedTab;
    private IServiceProvider serviceProvider;



    public MainViewModel(IServiceProvider sp)
    {
        serviceProvider = sp;
        var lht = sp.GetService<HoummieViewModel>();
        lht.Title = "Спадарства"; lht.Icon = nameof(Icons.Hoummie);
        var lst = sp.GetService<SettingsViewModel>();
        lst.Title = "Настройки"; lst.Icon = nameof(Icons.Settings);
        var lat = sp.GetService<AnaliticsSetsViewModel>();
        lat.Title = "Справочники"; lat.Icon = nameof(Icons.AnaliticsSets);
        var lsect = sp.GetService<SecurityViewModel>();
        lsect.Title = "Безопасность"; lsect.Icon = nameof(Icons.Security);

        LeftTabs = new ObservableCollection<LeftTabsViewModel>()
        {
            lht, lst, lat, lsect
        };


        var rit = sp.GetService<InformationViewModel>();
        rit.Title = "Информация"; rit.Icon = nameof(Icons.Information);
        var rnt = sp.GetService<NotificationsViewModel>();
        rnt.Title = "Уведомления"; rnt.Icon = nameof(Icons.Notifications);
        var rrt = sp.GetService<ReportViewModel>();
        rrt.Title = "Отчет"; rrt.Icon = nameof(Icons.Report);
        var rft = sp.GetService<ForecastViewModel>();
        rft.Title = "Прогноз"; rft.Icon = nameof(Icons.Forecast);
        RightTabs = new ObservableCollection<RightTabsViewModel>()
        {
            rit, rnt, rrt, rft
        };

        ShowDialog(new LoginViewModel(nameof(MainViewModel), CloseDialog) { Title = "Заголовок окна", Message = "Данная программа представляет собой систему учета ресурсов." });
    }

    public void SwitchToRightTab(string name)
    {
        var tab = RightTabs.First(x => x.Title == name);
        RightSelectedTab = tab;
    }

    protected void ShowDialog(ViewModelBase vm)
    {
        MainViewOpacity = 0.3;
        ModelOpacity = 1.0;
        MainViewEnabled = false;
        ModelEnabled = true;
        Model = vm;
    }

    protected void CloseDialog(ViewModelBase vm)
    {
        MainViewOpacity = 1.0;
        ModelOpacity = 0;
        MainViewEnabled = true;
        ModelEnabled = false;
        Model = null;
        if (vm is MessageBoxViewModel dvm)
        {

        }
    }

    public void SwitchToLeftTab(string tabName)
    {
        var tab = LeftTabs.First(x => x.Title == tabName);
        LeftSelectedTab = tab;
    }

    public void SwitchToRighttTab(string tabName)
    {
        var tab = RightTabs.First(x => x.Title == tabName);
        RightSelectedTab = tab;
    }

    public void CloseRightPanel()
    {
        // OnPropertyChanged(nameof(LeftSelectedTab)+"."+nameof(LeftSelectedTab.Nodes));
        RightSelectedTab.TabContent = null;
        var sn = LeftSelectedTab.SelectedNode;
        LeftSelectedTab.SelectedNode = null;
        LeftSelectedTab.SelectedNode = sn;
    }

    public void ShowRightPanel(TabViewPanelViewModel panel)
    {
        RightSelectedTab.TabContent = panel;
    }

    public ViewModelBase ViewModel()
    {
        return this;
    }

    protected virtual void OnLeftSelectedTabChanged(string tabName)
    {
        TabViewPanelViewModel? panel = null;
        if(tabName == "Спадарства")
        {
            panel = serviceProvider.GetService<HiAddHoummieViewModel>();
        }
        else if(tabName == "Справочники")
        {
            if(LeftSelectedTab.SelectedNode is null)
            {
                panel = serviceProvider.GetService<HiAddAnaliticViewModel>();
            }
        }
        if(panel != null)
        {
            SwitchToRighttTab("Информация");
            ShowRightPanel(panel);
        }
        else
        {
            ShowRightPanel(null!);
        }
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(LeftSelectedTab))
        {
            OnLeftSelectedTabChanged(LeftSelectedTab.Title);
        }
        base.OnPropertyChanged(e);
    }

}
