using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MicroMoney.ViewModels
{
    public abstract partial class LeftTabsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? title;
        [ObservableProperty]
        private string? icon;
    }
}