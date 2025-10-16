using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Sqlite.Models
{
    /// <summary>
    /// 实体类型
    /// </summary>
    public class EntityBase : ObservableObject
    {
        private int id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return id; }
            set => SetProperty(ref id, value);
        }

        private DateTime insertDate = DateTime.Now;

        public DateTime InsertDate
        {
            get => insertDate;
            set => SetProperty(ref insertDate, value);
        }


    }
}
