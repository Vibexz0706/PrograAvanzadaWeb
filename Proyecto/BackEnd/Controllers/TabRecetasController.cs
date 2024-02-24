using Backend.Models;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabRecetasController : ControllerBase
    {

        ITabRecetaService TabRecetaService;

        public TabRecetasController(ITabRecetaService tabRecetaService)
        {
            TabRecetaService = tabRecetaService;
        }

        // GET: api/<TabRecetaController>
        [HttpGet]
        public IEnumerable<TabRecetaModel> Get()
        {
            return TabRecetaService.GetTabRecetas();
        }

        // GET api/<TabRecetaController>/5
        [HttpGet("{id}")]
        public TabRecetaModel Get(int id)
        {
            return TabRecetaService.GetById(id);
        }

        // POST api/<TabRecetaController>
        [HttpPost]
        public string Post([FromBody] TabRecetaModel tabReceta)
        {
            var result = TabRecetaService.AddTabReceta(tabReceta);

            if (result)
            {
                return "Entidad agregada con exito.";
            }
            return "Hubo un error al agregar la entidad.";

        }

        // PUT api/<TabRecetaController>/5
        [HttpPut]
        public string Put([FromBody] TabRecetaModel tabReceta)
        {
            var result = TabRecetaService.UpdateTabReceta(tabReceta);

            if (result)
            {
                return "Entidad editada con éxito.";
            }
            return "Hubo un error al editar la entidad.";
        }


        // DELETE api/<TabRecetaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            TabRecetaModel tabReceta = new TabRecetaModel { IdReceta = id };
            var result = TabRecetaService.DeteleTabReceta(tabReceta);

            if (result)
            {
                return "Entidad eliminada con exito.";
            }
            return "Hubo un error al eliminar la entidad.";

        }
    }
}
