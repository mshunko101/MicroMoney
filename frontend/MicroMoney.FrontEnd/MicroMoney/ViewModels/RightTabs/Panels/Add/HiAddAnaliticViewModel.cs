using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroMoney.ViewModels.LeftTabs;
using MicroMoney.ViewModels.RightTabs.Panels.Information;

namespace MicroMoney.ViewModels.RightTabs.Panels.Add
{
    public class HiAddAnaliticViewModel : TabViewPanelViewModel
    {
        AnaliticsSetsViewModel model;
        public HiAddAnaliticViewModel(AnaliticsSetsViewModel model)
        {
            this.model = model;
        }

        public void AddCommand()
        {
            model.AddNodeCommand();
        }
    }
}