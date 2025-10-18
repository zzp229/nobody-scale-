using Company.Sqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 无人值守地磅称重系统课程.Interfaces
{
    public interface ISession
    {
        string Title { get; set; }
        User CurrentUser { get; set; }
    }
}
