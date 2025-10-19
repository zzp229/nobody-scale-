using _12窗体传参.Message;
using _12窗体传参.Model;
using _12窗体传参.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _12窗体传参.ViewModel
{
    public class SessionViewModel : ObservableObject
    {
        private readonly IServiceProvider _serviceProvider;
        public SessionViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            OpenMainView();
            testPara = new RelayCommand(ExecuteTestPara);
            
        }

        private void OpenMainView()
        {
            var mainView = _serviceProvider.GetService<MainView>();
            mainView.Show();
        }

        private void ExecuteTestPara()
        {
            MessageBox.Show("传参测试：");

            User user = new User()
            {
                Id = 123,
                Name = "测试用户"
            };

            WeakReferenceMessenger.Default.Send(new LoginMessage(user));


        }

        public ICommand testPara { get; set; }

    }
}
