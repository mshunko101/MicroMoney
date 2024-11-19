using System;
using System.Collections.ObjectModel;
using MicroMoney.Services.Abstract;
using MicroMoney.ViewModels.RightTabs.Panels.Information;
using MicroMoney.ViewModels.TreeViewNodes;
using MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet;
using Microsoft.Extensions.DependencyInjection;

namespace MicroMoney.ViewModels.LeftTabs
{
    public class AnaliticsSetsViewModel : LeftTabsViewModel
    {
        private IServiceProvider serviceProvider;
        public AnaliticsSetsViewModel(IServiceProvider sp)
        {
            serviceProvider = sp;
            SelectedNodes = new ObservableCollection<TreeViewNode>();
            Nodes = new ObservableCollection<TreeViewNode>();
        }

        public override void AddNodeCommand()
        {
            if (SelectedNode is null)
            {
                var node = AnaliticTreeNode.Create();
                Nodes.Add(node);
                var mainModel = serviceProvider.GetService<IUiService>() ?? throw new ArgumentNullException();
                mainModel.SwitchToRightTab("Информация");

                var tabContent = serviceProvider.GetService<ManageAnaliticViewModel>() ?? throw new ArgumentNullException();
                tabContent.Node = node;
                mainModel.ShowRightPanel(tabContent);
                SelectedNode = node;
            }
            else
            {
                var mainModel = serviceProvider.GetService<IUiService>() ?? throw new ArgumentNullException();
                mainModel.SwitchToRightTab("Информация");

                var tabContent = serviceProvider.GetService<ManageAnaliticDataSetViewModel>() ?? throw new ArgumentNullException();
                tabContent.Item = SelectedNode as AnaliticTreeNode;
                tabContent.Init();
                mainModel.ShowRightPanel(tabContent);
            }
        }

        protected override void OnSelectedNodeChanged()
        {
            if(SelectedNode is AnaliticTreeNode an && an.DataType != null)
            {
                var mainModel = serviceProvider.GetService<IUiService>() ?? throw new ArgumentNullException();
                mainModel.SwitchToRightTab("Информация");

                var tabContent = serviceProvider.GetService<ManageAnaliticDataSetViewModel>() ?? throw new ArgumentNullException();
                tabContent.Item = SelectedNode as AnaliticTreeNode;
                tabContent.Init();
                mainModel.ShowRightPanel(tabContent);
            } 
        }

        public override void DelNodeCommand()
        {

        }
    }
}