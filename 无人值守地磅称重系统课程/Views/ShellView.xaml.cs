using CommunityToolkit.Mvvm.Messaging;
using Company.Sqlite.Interfaces;
using Company.Sqlite.Models;
using MahApps.Metro.Controls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using 无人值守地磅称重系统课程.Interfaces;
using 无人值守地磅称重系统课程.Models.Message;
using 无人值守地磅称重系统课程.ViewModels;

namespace 无人值守地磅称重系统课程.Views
{
    /// <summary>
    /// ShellView.xaml 的交互逻辑
    /// </summary>
    public partial class ShellView : MetroWindow
    {
        private ISession Session { get; }
        public ShellView(IUserRepository userRepository, ISession session)
        {
            InitializeComponent();
            Session = session; 
            DataContext = App.Current.Services.GetService<ShellViewModel>();
            User user = userRepository.Select("admin");
            if (user == null)
            {
                user = new User();
                user.UserName = "admin";
                user.Password = "12345678";
                user.Role = 0; //0代表超级管理员
                user.InsertDate = DateTime.Now;
                var count = userRepository.Insert(user);
                if (count > 0)
                {
                    MessageBox.Show("已自动创建初始管理员账号：admin，密码：12345678，请登录后尽快修改密码！");
                }
            }

            container.Content = App.Current.Services.GetService<LoginView>();

            // 登录成功后跳转到主页面
            // 这里是接收消息
            WeakReferenceMessenger.Default.Register<LoginSuccessMessage>(this, (sender, arg) =>
            {
                Session.CurrentUser = arg.Value;    // value是发布时候的user
                container.Content = App.Current.Services.GetService<MainView>();
                WindowState = WindowState.Normal;
                Width = 1880;
                Height = 1000;
                SetWindow();
            });
        }

        private void SetWindow()
        {
            Left = (SystemParameters.WorkArea.Width - Width) / 2;
            Top = (SystemParameters.WorkArea.Height - Height) / 2;

        }
    }
}
