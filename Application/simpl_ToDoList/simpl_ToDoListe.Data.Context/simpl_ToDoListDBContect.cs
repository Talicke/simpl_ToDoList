using Microsoft.EntityFrameworkCore;
using simpl_ToDoList.Data.Entity;
using simpl_ToDoList.Data.Context.Contrat;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace simpl_ToDoList.Data.Context
{
    public class simpl_ToDoListDBContect :DbContext, Isimpl_ToDoListDBContect
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

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            return await SaveChangesAsync(cancellationToken);
        }

        public async Task<int> SaveChangeAsync(bool AcceptAllChangesOnSucces, CancellationToken cancellationToken = default)
        {
            return await SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var User = new User()
            {
                IdUser = 1,
                FirstName = "Val",
                LastName = "Ras",
                Email = "blabla@gmail.com",
            };

            var status = new Status()
            {
                idStatus = 1,
                Value = "A Faire"
            };
            var status2 = new Status()
            {
                idStatus = 2,
                Value = "En cours"
            };
            var status3 = new Status()
            {
                idStatus = 3,
                Value = "Terminée"
            };

            modelBuilder.Entity<Status>().HasData(status);
            modelBuilder.Entity<Status>().HasData(status2);
            modelBuilder.Entity<Status>().HasData(status3);
            modelBuilder.Entity<User>().HasData(User);
        }
    }

}
