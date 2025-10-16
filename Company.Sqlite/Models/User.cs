using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Sqlite.Models
{
    [Table(nameof(User))]
    public class User : EntityBase
    {
		private string userName;

		public string UserName 
		{
			get { return userName; }
			set { SetProperty(ref userName, value); }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { SetProperty(ref password, value); }
		}

		private int role;

		public int Role
		{
			get { return role; }
			set { SetProperty(ref role, value); }
		}



	}
}
