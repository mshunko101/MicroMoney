using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MicroMoney.ViewModels.TreeViewNodes;

namespace MicroMoney.ViewModels.LeftTabs
{
    public abstract partial class LeftTabsViewModel : TabViewModel
    {
        [ObservableProperty]
        private string? selectedTreePath;
        [ObservableProperty]
        private ObservableCollection<TreeViewNode> selectedNodes;
        [ObservableProperty]
        private TreeViewNode selectedNode;
        [ObservableProperty]
        private ObservableCollection<TreeViewNode> nodes;

        public virtual void AddNodeCommand()
        {
          
        }

        public virtual void DelNodeCommand()
        {
            
        }


        public virtual void OnSelectedNodeChanged()
        {

        }

        protected virtual void OnSelectedNodesChanged()
        {
            
        }
        
        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(SelectedNodes))
            {
                OnSelectedNodesChanged();
            }
            else if(e.PropertyName == nameof(SelectedNode))
            {
                OnSelectedNodeChanged();
            }
            base.OnPropertyChanged(e);
        }
    }
}