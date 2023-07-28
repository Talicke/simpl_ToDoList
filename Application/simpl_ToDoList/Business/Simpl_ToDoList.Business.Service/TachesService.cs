using AutoMapper;
using simpl_ToDoList.Data.Entity;
using simpl_ToDoList.Data.Repository.Contrat;
using Simpl_ToDoList.Business.Models.Taches;
using Simpl_ToDoList.Business.Service.Contrat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpl_ToDoList.Business.Service
{
    public class TachesService : ITachesService
    {
        private readonly ITachesRepository _tachesRepository;
        private readonly IMapper _mapper;

        public TachesService(ITachesRepository tachesRepository, IMapper mapper)
        {
            _tachesRepository = tachesRepository;
            _mapper = mapper;
        }
        public async Task<List<ReadTachesDTO>> GetTaches()
        {
            var taches = await _tachesRepository.SelecAllAsync().ConfigureAwait(false);

            return _mapper.Map<List<ReadTachesDTO>>(taches);
        }
        

        public async Task<ReadTachesDTO> CreateTachesAsync(CreateTachesDTO tachescreate)
        {
            var taches = _mapper.Map<Tache>(tachescreate);

            var tachesCreated = await _tachesRepository.Creer(taches).ConfigureAwait(false);

            return _mapper.Map<ReadTachesDTO>(tachesCreated);

        }
    }
}
