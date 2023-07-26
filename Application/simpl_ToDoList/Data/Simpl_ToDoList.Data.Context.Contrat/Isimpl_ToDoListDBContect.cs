using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpl_ToDoList.Data.Context.Contrat
{
    public interface Isimpl_ToDoListDBContect : IDbContext
    {
          DbSet<User> Users { get; set; }
          DbSet<Tache> Taches { get; set; }
          DbSet<Status> Statuss { get; set; }
    }
}
