using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpl_ToDoList.Data.Context.Contrat
{
    public interface IDbContext
    {
        int SaveChanges();
        int SaveChanges(bool AcceptAllChangesOnSucces);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
        Task<int> SaveChangeAsync(bool AcceptAllChangesOnSucces, CancellationToken cancellationToken = default);
        DatabaseFacade DatabaseFacade { get; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        EntityEntry<TEntity> Entry<TEntity>([NotNull] TEntity entity) where TEntity : class;
        EntityEntry<TEntity> Attach<TEntity>([NotNull] TEntity entity) where TEntity : class;
    }
}
