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
using MicroMoney.Services.Abstract;

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

        public override void AddNodeCommand()
        {
            var node = new HoummieTreeViewNode(SelectedNode);
            Nodes.Add(node);
            var mainModel = serviceProvider.GetService<IUiService>() ?? throw new ArgumentNullException();
            mainModel.SwitchToRightTab("Информация");

            var tabContent = serviceProvider.GetService<ManageHoummieViewModel>() ?? throw new ArgumentNullException();
            tabContent.Node = node;
            mainModel.ShowRightPanel(tabContent);
            SelectedNode = node;
        }

        public override void DelNodeCommand()
        {
            
        }

    }
}