using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MicroMoney.ViewModels.TreeViewNodes;

namespace MicroMoney.ViewModels.RightTabs
{
    public abstract partial class RightTabsViewModel : TabViewModel
    {
        [ObservableProperty]
        private TabViewPanelViewModel tabContent;
    }
}