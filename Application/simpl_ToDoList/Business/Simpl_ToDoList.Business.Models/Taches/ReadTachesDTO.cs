using simpl_ToDoList.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpl_ToDoList.Business.Models.Taches
{
    public class ReadTachesDTO: CreateTachesDTO
    {
        public int Id { get; set; }


    }
}
