using System;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using MicroMoney.Services.Abstract;
using MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet;

namespace MicroMoney.ViewModels.RightTabs.Panels.Information
{
    public class AnaliticsTypeItem
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public Type Type {get;set;}
    }

    public partial class ManageAnaliticViewModel : TabViewPanelViewModel
    {
        [ObservableProperty]
        private string analiticName;
        [ObservableProperty]
        private string analiticDescription;
        [ObservableProperty]
        private string analiticType;
        IUiService _uiService;
        public AnaliticTreeNode Node {get;set;}
        [ObservableProperty]
        private ObservableCollection<AnaliticsTypeItem> analiticTypes;
        [ObservableProperty]
        private int typeSelectedIndex;

        public ManageAnaliticViewModel(IUiService uiService)
        {
            _uiService = uiService;
            int id = 0;
            var types = AnaliticDataTreeNode.GetSupportedTypes().Select(x => new AnaliticsTypeItem(){Id = id++, Name = x.Name, Type = x});
            AnaliticTypes = new ObservableCollection<AnaliticsTypeItem>(); 
            AnaliticTypes = [.. types];
        }

        public void SaveCommand()
        {
            if(Node != null && Node is AnaliticTreeNode node)
            {
                Node.AnaliticName = AnaliticName;
                Node.AnaliticDescription = AnaliticDescription;
                Node.Title = AnaliticName;
                Node.DataType = AnaliticTypes.First(x => x.Id == TypeSelectedIndex).Type;
                
                AnaliticName = string.Empty;
                AnaliticDescription = string.Empty;
            }
            _uiService.CloseRightPanel();
        }

        public void CancelCommand()
        {
            _uiService.CloseRightPanel();
        }
    }
}