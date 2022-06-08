using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    internal class TodoModel
    {
        ///При создании модели TodoModel сразу будет присваиваться текущая дата
        public DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _isDone;

        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }    
        }
    }
}
