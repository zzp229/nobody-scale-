using _12窗体传参.Model;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12窗体传参.Message
{
    internal class LoginMessage : ValueChangedMessage<User>
    {
        public LoginMessage(User value) : base(value)
        {
        }
    }
}
