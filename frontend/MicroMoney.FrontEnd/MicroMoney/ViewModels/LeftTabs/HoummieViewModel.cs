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
using MicroMoney.ViewModels.Controls;
using MicroMoney.ViewModels.RightTabs.Panels;
using MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet;

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

        protected override void OnSelectedNodeChanged()
        {
            var mainModel = serviceProvider.GetService<IUiService>() ?? throw new ArgumentNullException();
            mainModel.SwitchToRightTab("Информация");

            var tabContent = serviceProvider.GetService<AnaliticViewModel>() ?? throw new ArgumentNullException();

            var root =  AnaliticTreeNode.Create();

            var type1 = AnaliticTreeNode.Create();
            type1.AnaliticName = "Тип продукта";// мясо молоко яйца рыба
            type1.Parent = root;
            type1.AnaliticId = 1;

            var type2 = AnaliticTreeNode.Create();
            type2.AnaliticName = "Вид продукта";// марки
            type2.Parent = root;
            type2.AnaliticId = 2;

            var type3 = AnaliticTreeNode.Create();// килограммы штуки пачки
            type3.AnaliticName = "Количество продукта";
            type3.Parent = root;
            type3.AnaliticId = 3;

            

            tabContent.Item = root;
            mainModel.ShowRightPanel(tabContent);
        
        }
    }
}