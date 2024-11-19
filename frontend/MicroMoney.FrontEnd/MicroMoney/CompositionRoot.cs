using MicroMoney.Services.Abstract;
using MicroMoney.ViewModels;
using MicroMoney.ViewModels.LeftTabs;
using MicroMoney.ViewModels.RightTabs;
using MicroMoney.ViewModels.RightTabs.Panels.Add;
using MicroMoney.ViewModels.RightTabs.Panels.Information;
using Microsoft.Extensions.DependencyInjection;

namespace MicroMoney
{
    public static class CompositionRoot
    {
        public static void Compose(this IServiceCollection collection)
        {
            collection.AddSingleton<IUiService,MainViewModel>();
            collection.AddSingleton<LoginViewModel>();
            collection.AddSingleton<MessageBoxViewModel>();

            collection.AddSingleton<AnaliticsSetsViewModel>();
            collection.AddSingleton<MessageBoxViewModel>();
            collection.AddSingleton<SecurityViewModel>();
            collection.AddSingleton<SettingsViewModel>();
            collection.AddSingleton<HoummieViewModel>();

            collection.AddSingleton<InformationViewModel>();
            collection.AddSingleton<NotificationsViewModel>();
            collection.AddSingleton<ForecastViewModel>();
            collection.AddSingleton<ReportViewModel>();

            collection.AddScoped<ManageHoummieViewModel>();
            collection.AddScoped<ManageAnaliticViewModel>();
            collection.AddScoped<ManageAnaliticDataSetViewModel>();     
            collection.AddScoped<HiAddHoummieViewModel>();
            collection.AddScoped<HiAddAnaliticViewModel>();
            collection.AddScoped<HiAddAnaliticDataViewModel>();
            
        }
    }
}