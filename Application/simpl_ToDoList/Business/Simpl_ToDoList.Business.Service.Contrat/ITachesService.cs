using Simpl_ToDoList.Business.Models.Taches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpl_ToDoList.Business.Service.Contrat
{
    public interface ITachesService
    {
        Task<List<ReadTachesDTO>> GetTaches();
        Task<ReadTachesDTO> CreateTachesAsync(CreateTachesDTO tachescreate);
        Task<ReadTachesDTO> UpdateTachesAsync(int id, CreateTachesDTO tachesUpdate);
        Task<ReadTachesDTO> DeleteTachesAsync(int id);
        Task<List<ReadTachesDTO>> GetTachesByStatus(int Idstatus);
    }
}
