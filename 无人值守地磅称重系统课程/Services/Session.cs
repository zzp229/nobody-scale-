using CommunityToolkit.Mvvm.ComponentModel;
using Company.Sqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 无人值守地磅称重系统课程.Interfaces;

namespace 无人值守地磅称重系统课程.Services
{
    public class Session : ObservableObject, ISession
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
          
        private User user = new User();

        public User CurrentUser
        {
            get { return user; }
            set { SetProperty(ref user, value); }
        }


    }
}
