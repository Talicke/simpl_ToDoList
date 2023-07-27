using simpl_ToDoList.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpl_ToDoList.Business.Models.Taches
{
    public class CreateTachesDTO
    {
        public string title { get; set; }
        public string? DesTache { get; set; }
        public DateTime CreatedDatetache { get; set; }
        public DateTime? DueDatetache { get; set; }
        public int idStatus { get; set; }
        public int idUser { get; set; }

    }
}
