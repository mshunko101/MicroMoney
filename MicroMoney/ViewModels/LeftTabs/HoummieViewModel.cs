using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MicroMoney.ViewModels.TreeViewNodes;
using Microsoft.Extensions.DependencyInjection;
using MicroMoney.ViewModels.RightTabs.Panels.Information;

namespace MicroMoney.ViewModels.LeftTabs
{
    public partial class HoummieViewModel : LeftTabsViewModel
    {
        private IServiceProvider serviceProvider;
        public HoummieViewModel(IServiceProvider sp)
        {
            serviceProvider = sp;
            SelectedNodes = new ObservableCollection<TreeViewNode>();
            Nodes = new ObservableCollection<TreeViewNode>();
        }

        protected void OnSelectedNodesChanged()
        {
            
        }

        public override void AddNodeCommand()
        {
            if(SelectedNode == null)
            {
                
            }
            Nodes.Add(new TreeViewNode("Node", SelectedNode, new (){SelectedNode}));
        }

        public override void DelNodeCommand()
        {
            
        }

        public void OnSelectedNodeChanged()
        {
            var mainModel = serviceProvider.GetService<MainViewModel>();

            mainModel.SwitchToRightTab("Информация");

            var tabContent = serviceProvider.GetService<ManageHoummieViewModel>();
            mainModel.RightSelectedTab.TabContent = tabContent;
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