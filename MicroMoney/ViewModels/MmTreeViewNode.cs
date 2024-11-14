using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MicroMoney.ViewModels
{
    public partial class MmTreeViewNode : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<MmTreeViewNode>? subNodes;
        [ObservableProperty]
        private string title;
  
        public MmTreeViewNode(string title)
        {
            Title = title;
        }

        public MmTreeViewNode(string title, ObservableCollection<MmTreeViewNode> subNodes)
        {
            Title = title;
            SubNodes = subNodes;
        }
    }
}