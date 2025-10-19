using _12窗体传参.View;
using _12窗体传参.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _12窗体传参
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; private set; }
        public App()
        {
            var services = new ServiceCollection();
            services.AddSingleton<MainView>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<SessionView>();
            services.AddSingleton<SessionViewModel>();

            Services = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Services.GetService<SessionView>().Show();
        }



    }

    
}
