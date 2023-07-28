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
        public async Task<List<ReadTachesDTO>> GetTachesByStatus(int Idstatus)
        {
            var taches = await _tachesRepository.GetTachesByStatusAsync(Idstatus).ConfigureAwait(false);

            return _mapper.Map<List<ReadTachesDTO>>(taches);
        }

        public async Task<ReadTachesDTO> CreateTachesAsync(CreateTachesDTO tachescreate)
        {
            var taches = _mapper.Map<Tache>(tachescreate);

            var tachesCreated = await _tachesRepository.Creer(taches).ConfigureAwait(false);

            return _mapper.Map<ReadTachesDTO>(tachesCreated);

        }

        public async Task<ReadTachesDTO> UpdateTachesAsync(int id, CreateTachesDTO tachesUpdate)
        {
            var taches = _mapper.Map<Tache>(tachesUpdate);

            if (tachesUpdate == null)
            {
                throw new ArgumentNullException(nameof(tachesUpdate));
            }

            var TAcheExist = await _tachesRepository.SelecAvecId(id).ConfigureAwait(false);

            if (TAcheExist == null)
            {
                throw new Exception($"Il n'existe aucun produit avec cet identifiant : {id}");
            }


            TAcheExist.DueDatetache= tachesUpdate.DueDatetache;
            TAcheExist.CreatedDatetache = tachesUpdate.CreatedDatetache;
            TAcheExist.title = tachesUpdate.title;
            TAcheExist.DesTache= tachesUpdate.DesTache;
            TAcheExist.idStatus = tachesUpdate.idStatus;
            TAcheExist.idUser = tachesUpdate.idUser;

            //var ClientModifier = ClientMapper.TransformLireClientDTOtoEntity(clientExist);
            var tachesUpdated = await _tachesRepository.Modifier(TAcheExist).ConfigureAwait(false);

            return _mapper.Map<ReadTachesDTO>(tachesUpdated);

        }


        public async Task<ReadTachesDTO> DeleteTachesAsync(int id)
        {
            var TAcheExist = await _tachesRepository.SelecAvecId(id).ConfigureAwait(false);

            if (TAcheExist == null)
            {
                throw new Exception($"Il n'existe aucun produit avec cet identifiant : {id}");
            }

            //var ClientModifier = ClientMapper.TransformLireClientDTOtoEntity(clientExist);
            var tachesSuppr= await _tachesRepository.Supprimer(TAcheExist).ConfigureAwait(false);

            return _mapper.Map<ReadTachesDTO>(tachesSuppr);

        }
    }
}
