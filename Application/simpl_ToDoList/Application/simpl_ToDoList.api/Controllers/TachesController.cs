using Microsoft.AspNetCore.Mvc;
using simpl_ToDoList.Data.Repository.Contrat;
using Simpl_ToDoList.Business.Models.Taches;
using Simpl_ToDoList.Business.Service.Contrat;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace simpl_ToDoList.api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TachesController : ControllerBase
    {
        private ITachesService _tachesServices;

        public TachesController(ITachesService tachesService)
        {
            _tachesServices = tachesService;
        }
            
            
            
            
        // GET: api/<TachesController>
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var taches = await _tachesServices.GetTaches().ConfigureAwait(false);
            return Ok(taches);

        }


        // POST api/<TachesController>
        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CreateTachesDTO tachescreate)
        {
            var tache = await _tachesServices.CreateTachesAsync(tachescreate).ConfigureAwait(false);
            return Ok(tache);

        }

    }
}
