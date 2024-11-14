using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MicroMoney.ViewModels
{
    public abstract partial class EmbedViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string? _caller;

        protected Action<EmbedViewModel>? _closeCallBack;

        protected EmbedViewModel(string caller, Action<EmbedViewModel> closeCallBack)
        {
            _caller = caller;
            _closeCallBack = closeCallBack;
        }

    }
}