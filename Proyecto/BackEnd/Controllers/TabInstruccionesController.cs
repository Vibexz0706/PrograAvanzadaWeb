using Backend.Models;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabInstruccionesController : ControllerBase
    {

        ITabInstruccionService TabInstruccionService;

        public TabInstruccionesController(ITabInstruccionService tabEstadoService)
        {
            TabInstruccionService = tabEstadoService;
        }

        // GET: api/<TabInstruccionController>
        [HttpGet]
        public IEnumerable<TabInstruccionModel> Get()
        {
            return TabInstruccionService.GetTabInstrucciones();
        }

        // GET api/<TabInstruccionController>/5
        [HttpGet("{id}")]
        public TabInstruccionModel Get(int id)
        {
            return TabInstruccionService.GetById(id);
        }

        // POST api/<TabInstruccionController>
        [HttpPost]
        public string Post([FromBody] TabInstruccionModel tabEstado)
        {
            var result = TabInstruccionService.AddTabInstruccion(tabEstado);

            if (result)
            {
                return "Entidad agregada con exito.";
            }
            return "Hubo un error al agregar la entidad.";

        }

        // PUT api/<TabInstruccionController>/5
        [HttpPut]
        public string Put([FromBody] TabInstruccionModel tabEstado)
        {
            var result = TabInstruccionService.UpdateTabInstruccion(tabEstado);

            if (result)
            {
                return "Entidad editada con éxito.";
            }
            return "Hubo un error al editar la entidad.";
        }


        // DELETE api/<TabInstruccionController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            TabInstruccionModel tabEstado = new TabInstruccionModel { IdInstrucciones = id };
            var result = TabInstruccionService.DeteleTabInstruccion(tabEstado);

            if (result)
            {
                return "Entidad eliminada con exito.";
            }
            return "Hubo un error al eliminar la entidad.";

        }
    }
}
