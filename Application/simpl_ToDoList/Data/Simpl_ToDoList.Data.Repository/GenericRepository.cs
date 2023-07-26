using Microsoft.EntityFrameworkCore;
using simpl_ToDoList.Data.Context.Contrat;
using simpl_ToDoList.Data.Repository.Contrat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpl_ToDoList.Data.Repository
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class
    {
        private readonly Isimpl_ToDoListDBContect _DbContext;

        private readonly DbSet<T> _Table;
        public GenericRepository(Isimpl_ToDoListDBContect Dbcontext)
        {
            _DbContext = Dbcontext;
            _Table: Dbcontext.Set<T>();
        }

        public Task<T> Creer(T nouveauClient)
        {
            throw new NotImplementedException();
        }

        public Task<T> Modifier(T modifClient)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> SelecAllAsync()
        {
            return await _Table.ToListAsync().ConfigureAwait(false);
        }

        public Task<T> SelecAvecId(int idClient)
        {
            throw new NotImplementedException();
        }

        public Task<T> Supprimer(T supprClient)
        {
            throw new NotImplementedException();
        }
    }
}
