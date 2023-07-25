using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpl_ToDoList.Data.Entity
{
    public class Task
    {
        public int IdTask { get; set; }
        public string title { get; set; }
        public string? DesTask { get; set; }
        public DateTime CreatedDateTask { get; set; }
        public DateTime? DueDateTask { get; set; }
        
        public int idStatus { get; set; }
        public virtual Status Status { get; set; }

    }
}
