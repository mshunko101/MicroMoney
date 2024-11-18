using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroMoney.ViewModels;

namespace MicroMoney.Services.Abstract
{
    public interface IUiService
    {
        void SwitchToRightTab(string tabName);
        void SwitchToLeftTab(string tabName);
        void ShowRightPanel(TabViewPanelViewModel panel);
        void CloseRightPanel();
        ViewModelBase ViewModel();
    }
}