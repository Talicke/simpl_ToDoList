using Microsoft.EntityFrameworkCore;
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
    public class TachesRepository: GenericRepository<Tache>, ITachesRepository
    {
        private readonly Isimpl_ToDoListDBContect _DbContext;

        public TachesRepository(Isimpl_ToDoListDBContect Dbcontext) : base(Dbcontext)
        {
            _DbContext = Dbcontext;
        }

        public async Task<List<Tache>> GetTachesByStatusAsync(string status)
        {
            return await _Table.Where(x => x.Status.ToString()== status).ToListAsync().ConfigureAwait(false);
        }
    }
}
