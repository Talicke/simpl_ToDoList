using simpl_ToDoList.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpl_ToDoList.Data.Repository.Contrat
{
    public interface ITachesRepository : IGenericRepository<Tache>
    {
        Task<List<Tache>> GetTachesByStatusAsync(int Idstatus);
    }
}
