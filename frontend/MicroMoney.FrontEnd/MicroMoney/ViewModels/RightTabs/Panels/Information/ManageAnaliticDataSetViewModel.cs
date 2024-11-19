using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MicroMoney.Services.Abstract;
using MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet;

namespace MicroMoney.ViewModels.RightTabs.Panels.Information
{
    public partial class ManageAnaliticDataSetViewModel : TabViewPanelViewModel
    {
        [ObservableProperty]
        private ObservableCollection<AnaliticDataTreeNode> analiticSet;
        [ObservableProperty]
        private AnaliticTreeNode item;

        IUiService _uiService;

        public ManageAnaliticDataSetViewModel(IUiService uiService)
        {
            analiticSet = new ObservableCollection<AnaliticDataTreeNode>();
            _uiService = uiService;
        }

        public void Init()
        {
            AnaliticSet = [.. item.SubNodes.Cast<AnaliticDataTreeNode>()];
        }

        public void SaveCommand()
        {
            _uiService.CloseRightPanel();
        }

        public void CancelCommand()
        {
            _uiService.CloseRightPanel();
        }

        public void AddCommand()
        {
            AnaliticSet.Add(new AnaliticDataTreeNode(string.Empty, Item));
        }

        public void RemoveCommand()
        {
            
        }

    }
}