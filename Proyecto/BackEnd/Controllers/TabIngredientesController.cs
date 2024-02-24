using Backend.Models;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabIngredientesController : ControllerBase
    {

        ITabIngredienteService TabIngredienteService;

        public TabIngredientesController(ITabIngredienteService tabIngredienteService)
        {
            TabIngredienteService = tabIngredienteService;
        }

        // GET: api/<TabIngredienteController>
        [HttpGet]
        public IEnumerable<TabIngredienteModel> Get()
        {
            return TabIngredienteService.GetTabIngredientes();
        }

        // GET api/<TabIngredienteController>/5
        [HttpGet("{id}")]
        public TabIngredienteModel Get(int id)
        {
            return TabIngredienteService.GetById(id);
        }

        // POST api/<TabIngredienteController>
        [HttpPost]
        public string Post([FromBody] TabIngredienteModel tabIngrediente)
        {
            var result = TabIngredienteService.AddTabIngrediente(tabIngrediente);

            if (result)
            {
                return "Entidad agregada con exito.";
            }
            return "Hubo un error al agregar la entidad.";

        }

        // PUT api/<TabIngredienteController>/5
        [HttpPut]
        public string Put([FromBody] TabIngredienteModel tabIngrediente)
        {
            var result = TabIngredienteService.UpdateTabIngrediente(tabIngrediente);

            if (result)
            {
                return "Entidad editada con éxito.";
            }
            return "Hubo un error al editar la entidad.";
        }


        // DELETE api/<TabIngredienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            TabIngredienteModel tabIngrediente = new TabIngredienteModel { IdIngredientes = id };
            var result = TabIngredienteService.DeteleTabIngrediente(tabIngrediente);

            if (result)
            {
                return "Entidad eliminada con exito.";
            }
            return "Hubo un error al eliminar la entidad.";

        }
    }
}
