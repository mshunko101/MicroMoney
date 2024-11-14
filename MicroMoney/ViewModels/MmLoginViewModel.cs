using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroMoney.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MicroMoney.ViewModels
{
    public partial class MmLoginViewModel : EmbedViewModel
    {
        [ObservableProperty]
        private string? title;
        [ObservableProperty]
        private string? message;
        [ObservableProperty]
        private string? login;
        [ObservableProperty]
        private string? password;

        public MmLoginViewModel(string caller, Action<EmbedViewModel> closeCallBack)
        :base(caller, closeCallBack)
        {

        }

        public void LoginCommand()
        {
            _closeCallBack(this);
        }

        public void ExitCommand()
        {
            _closeCallBack(this);
        }
    }
}