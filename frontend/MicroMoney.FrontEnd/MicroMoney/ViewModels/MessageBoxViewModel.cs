using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroMoney.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MicroMoney.ViewModels
{
    public partial class MessageBoxViewModel : EmbedViewModel
    {
        [ObservableProperty]
        private string? title;
        [ObservableProperty]
        private string? message;

        public MessageBoxViewModel(string caller, Action<EmbedViewModel> closeCallBack)
        :base(caller, closeCallBack)
        {

        }

        public void CloseCommand()
        {
            _closeCallBack(this);
        }
    }
}