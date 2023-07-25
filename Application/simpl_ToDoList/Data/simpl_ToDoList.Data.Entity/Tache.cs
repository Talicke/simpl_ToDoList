using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpl_ToDoList.Data.Entity
{
    public class Tache
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTache { get; set; }
        public string title { get; set; }
        public string? DesTache { get; set; }
        public DateTime CreatedDatetache { get; set; }
        public DateTime? DueDatetache { get; set; }
        
        public int idStatus { get; set; }
        public virtual Status Status { get; set; }

        public int idUser { get; set; }
        public virtual User User { get; set; }

    }
}
