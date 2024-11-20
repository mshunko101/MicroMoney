using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet;

namespace MicroMoney.ViewModels.RightTabs.Panels
{
    public partial class AnaliticViewModel: TabViewPanelViewModel
    {
        [ObservableProperty]
        private AnaliticTreeNode item;
        [ObservableProperty]
        private AnaliticTreeNode selectedItem;

        public AnaliticViewModel()
        { 
        }
        
    }
}