using CommunityToolkit.Mvvm.ComponentModel;
using MicroMoney.Services.Abstract;
using MicroMoney.ViewModels.TreeViewNodes;

namespace MicroMoney.ViewModels.RightTabs.Panels.Information
{
    public partial class ManageHoummieViewModel:TabViewPanelViewModel
    {
        [ObservableProperty]
        private string? firstName;
        [ObservableProperty]
        private string? secondName;
        [ObservableProperty]
        private string? notes;
        public HoummieTreeViewNode Node{get;set;}
        IUiService _uiService;

        public ManageHoummieViewModel(IUiService uiService)
        {
            _uiService = uiService;
        }

        public void SaveCommand()
        {
            if(Node != null)
            {
                Node.FirstName = FirstName;
                Node.SecondName = SecondName;
                Node.Title = $"{SecondName} {FirstName}";
                FirstName = string.Empty;
                SecondName = string.Empty;
                Notes = string.Empty;
            }
            _uiService.CloseRightPanel();
        }

        public void CancelCommand()
        {
            _uiService.CloseRightPanel();
        }
    }
}