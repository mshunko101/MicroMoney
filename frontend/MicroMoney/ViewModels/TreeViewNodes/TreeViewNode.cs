using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MicroMoney.ViewModels.TreeViewNodes
{
    public partial class TreeViewNode : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<TreeViewNode>? subNodes;
        private string title;
        [ObservableProperty]
        private TreeViewNode parent;

        public virtual string Title
        {
            get {return title;}
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
  
        public TreeViewNode(string title, TreeViewNode parent)
        {
            Title = title;
        }

        public TreeViewNode(string title, TreeViewNode parent, ObservableCollection<TreeViewNode> subNodes)
        {
            Title = title;
            SubNodes = subNodes;
        }
    }
}