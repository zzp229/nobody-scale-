using CommunityToolkit.Mvvm.Input;
using Company.Sqlite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using 无人值守地磅称重系统课程.Interfaces;

namespace 无人值守地磅称重系统课程.ViewModels
{
    internal class LoginViewModel
    {
        public ICommand LoginCommand { get; set; }
        public ISession Session { get; }
        public IUserRepository UserRepository { get; set; }
        public LoginViewModel(ISession session, IUserRepository userRepository)
        {
            Session = session;

            UserRepository = userRepository;

            LoginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            if(string.IsNullOrEmpty(Session.CurrentUser.UserName) || string.IsNullOrEmpty(Session.CurrentUser.Password))
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }

            var list = UserRepository.GetAll();
            var user = list.Find(t=>t.UserName == Session.CurrentUser.UserName && t.Password == Session.CurrentUser.Password);
            if (user != null)
            {
            }
            else
            {
                MessageBox.Show("账号或密码错误！");
            }
        }
    }
}
