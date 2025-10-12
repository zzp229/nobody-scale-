using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 无人值守地磅称重系统课程.ViewModels;
using 无人值守地磅称重系统课程.Views;

namespace 无人值守地磅称重系统课程.Configure
{
    internal class ConfigureService
    {
        public static IServiceProvider Load()
        {
            var services = new ServiceCollection();

            // 注册UI层
            services.AddSingleton<ShellView>();
            services.AddSingleton<ShellViewModel>();

            services.AddSingleton<LoginView>();
            services.AddSingleton<LoginViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
