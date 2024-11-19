using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MicroMoney.ViewModels.TreeViewNodes
{
    public partial class HoummieTreeViewNode : TreeViewNode
    {
        [ObservableProperty]
        private string firstName;
        [ObservableProperty]
        private string secondName;
 
        public HoummieTreeViewNode(TreeViewNode parent)
        :base("", parent)
        {
        }
    }
}