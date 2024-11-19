using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroMoney.ViewModels.LeftTabs;

namespace MicroMoney.ViewModels.RightTabs.Panels.Add
{
    public class HiAddAnaliticDataViewModel : TabViewPanelViewModel
    {
        AnaliticsSetsViewModel model;
        public HiAddAnaliticDataViewModel(AnaliticsSetsViewModel model)
        {
            this.model = model;
        }

        public void AddCommand()
        {
            model.AddNodeCommand();
        }
    }
}