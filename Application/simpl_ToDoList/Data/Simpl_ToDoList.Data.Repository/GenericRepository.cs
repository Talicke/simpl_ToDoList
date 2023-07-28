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
    public abstract class GenericRepository<T>: IGenericRepository<T> where T : class
    {
        private readonly Isimpl_ToDoListDBContect _DbContext;

        protected readonly DbSet<T> _Table;
        public GenericRepository(Isimpl_ToDoListDBContect Dbcontext)
        {
            _DbContext = Dbcontext;
            _Table= Dbcontext.Set<T>();
        }

        public async Task<T> Creer(T newEntity)
        {
            var EntityAdded=await _Table.AddAsync(newEntity).ConfigureAwait(false);
            await _DbContext.SaveChangeAsync().ConfigureAwait(false);

            return EntityAdded.Entity;
        }

        public async Task<T> Modifier(T modifEntity)
        {
            var EntityUpdated = _Table.Update(modifEntity);
            await _DbContext.SaveChangeAsync().ConfigureAwait(false);

            return EntityUpdated.Entity;
        }

        public async Task<IEnumerable<T>> SelecAllAsync()
        {
            return await _Table.ToListAsync().ConfigureAwait(false);
        }

        public async Task<T> SelecAvecId(object idEntity)
        {

            return await _Table.FindAsync(idEntity).ConfigureAwait(false);
        }

        public async Task<T> Supprimer(T supprEntity)
        {
            var EntityDeleted = _Table.Remove(supprEntity);

            await _DbContext.SaveChangeAsync().ConfigureAwait(false);

            return EntityDeleted.Entity;
        }
    }
}
