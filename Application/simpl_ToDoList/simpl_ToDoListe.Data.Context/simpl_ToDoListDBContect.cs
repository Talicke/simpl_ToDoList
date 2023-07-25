using Microsoft.EntityFrameworkCore;
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
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual à_ èuuOo!l
PI%    }
}
