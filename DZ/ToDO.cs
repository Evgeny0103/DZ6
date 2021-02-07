using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class ToDo
    {
        public string Title { get; set; } // Описание задачи
        public bool IsDone { get; set; } // Пометка о ее выполнении

       

        public void duty(string title, bool isdone)
        {
            Title = title;
            IsDone = isdone;
        }

    }
}
