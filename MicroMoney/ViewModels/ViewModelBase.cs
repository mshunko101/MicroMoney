using CommunityToolkit.Mvvm.ComponentModel;
namespace MicroMoney.ViewModels;
using System.Collections.ObjectModel;
using System;
using System.Windows.Input;

public abstract partial class ViewModelBase : ObservableObject
{
    [ObservableProperty]
    private string? _caller;

    protected Action<ViewModelBase>? _closeCallBack;

    protected ViewModelBase(string caller, Action<ViewModelBase> closeCallBack)
    {
        _caller = caller;
        _closeCallBack = closeCallBack;
    }

    public ViewModelBase()
    {

    }
}
