using simpl_ToDoList.Data.Context.Contrat;
using simpl_ToDoList.Data.Entity;
using simpl_ToDoList.Data.Repository.Contrat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpl_ToDoList.Data.Repository
{
    public class StatusRepository : GenericRepository<Status>, IStatusRepository
    {
        public StatusRepository(Isimpl_ToDoListDBContect Dbcontext) : base(Dbcontext)
        {
        }
    }
}
