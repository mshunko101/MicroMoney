using CommunityToolkit.Mvvm.ComponentModel;
using MicroMoney.Views.Converters;
using System.Collections.ObjectModel;


namespace MicroMoney.ViewModels;

public partial class MainViewModel : ViewModelBase
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
    private ObservableCollection<LeftTabsViewModel> leftTabs;
 
    public MainViewModel()
    {   
        LeftTabs = new ObservableCollection<LeftTabsViewModel>()
        {
            new OrganizationsViewModel(){Title="Организации", Icon=nameof(Icons.Organization)}
        };
        ShowDialog(new MmLoginViewModel(nameof(MainViewModel), CloseDialog){Title="Заголовок окна", Message="Данная программа представляет собой систему учета ресурсов."});
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
        if(vm is MmMessageBoxViewModel dvm)
        {
            
        }
    }
}
