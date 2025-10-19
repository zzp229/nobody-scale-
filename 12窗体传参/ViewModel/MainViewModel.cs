using _12窗体传参.Message;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _12窗体传参.ViewModel
{
    public class MainViewModel : ObservableObject
    {
		private string txt;

		public string Txt
		{
			get { return txt; }
			set { SetProperty(ref txt, value); }
		}

        public MainViewModel()
        {
            Txt = "123";
            aaCommand = new CommunityToolkit.Mvvm.Input.RelayCommand(() =>
            {
                Txt = "456";
                MessageBox.Show("按钮被点击了");
            });

            WeakReferenceMessenger.Default.Register<LoginMessage>(this, (sender, arg) =>
            {
                Txt = $"接收到传参：Id={arg.Value.Id}, Name={arg.Value.Name}";
            });
        }

        public ICommand aaCommand { get; set; }
    }
}
