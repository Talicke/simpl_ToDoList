using Microsoft.EntityFrameworkCore;
using simpl_ToDoList.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpl_ToDoListe.Data.Context
{
    public class simpl_ToDoListDBContect :DbContext
    {
        public simpl_ToDoListDBContect()
        {

        }

        public simpl_ToDoListDBContect(DbContextOptions<simpl_ToDoListDBContect> options)
            : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Tache> Taches { get; set; }
        public virtual DbSet<Status> Statuss { get; set; }
    }
}
