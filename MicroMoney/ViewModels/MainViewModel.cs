using CommunityToolkit.Mvvm.ComponentModel;

namespace MicroMoney.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase? model;
    [ObservableProperty]
    private bool modelVisible;
    [ObservableProperty]
    private bool mainViewVisible;

    public MainViewModel()
    {
        ShowDialog(new MmMessageBoxViewModel(nameof(MainViewModel), CloseDialog));
    }

    protected void ShowDialog(ViewModelBase vm)
    {
        MainViewVisible = false;
        ModelVisible = true;
        Model = vm;
    }

    protected void CloseDialog(ViewModelBase vm)
    {
        MainViewVisible = true;
        ModelVisible = false;
        Model = null;
        if(vm is MmMessageBoxViewModel dvm)
        {
            
        }
    }
}
