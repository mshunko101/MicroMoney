using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroMoney.ViewModels;

namespace MicroMoney.ViewModels
{
    public class MmMessageBoxViewModel : ViewModelBase
    {
        public MmMessageBoxViewModel(string caller, Action<ViewModelBase> closeCallBack)
        :base(caller, closeCallBack)
        {

        }
    }
}