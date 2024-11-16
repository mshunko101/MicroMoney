using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MicroMoney.ViewModels.RightTabs.Panels.Information
{
    public partial class ManageHoummieViewModel:TabViewPanelViewModel
    {
        [ObservableProperty]
        private string? title;
        [ObservableProperty]
        private string? message;
        [ObservableProperty]
        private string? login;
        [ObservableProperty]
        private string? password;

        public ManageHoummieViewModel()
        {

        }

        public void LoginCommand()
        {
        }

        public void ExitCommand()
        {
        }
    }
}