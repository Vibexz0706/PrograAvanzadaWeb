using Backend.Models;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabEstadosController : ControllerBase
    {

        ITabEstadoService TabEstadoService;

        public TabEstadosController(ITabEstadoService tabEstadoService)
        {
            TabEstadoService = tabEstadoService;
        }

        // GET: api/<TabEstadoController>
        [HttpGet]
        public IEnumerable<TabEstadoModel> Get()
        {
            return TabEstadoService.GetTabEstados();
        }

        // GET api/<TabEstadoController>/5
        [HttpGet("{id}")]
        public TabEstadoModel Get(int id)
        {
            return TabEstadoService.GetById(id);
        }

        // POST api/<TabEstadoController>
        [HttpPost]
        public string Post([FromBody] TabEstadoModel tabEstado)
        {
            var result = TabEstadoService.AddTabEstado(tabEstado);

            if (result)
            {
                return "Entidad agregada con exito.";
            }
            return "Hubo un error al agregar la entidad.";

        }

        // PUT api/<TabEstadoController>/5
        [HttpPut]
        public string Put([FromBody] TabEstadoModel tabEstado)
        {
            var result = TabEstadoService.UpdateTabEstado(tabEstado);

            if (result)
            {
                return "Entidad editada con éxito.";
            }
            return "Hubo un error al editar la entidad.";
        }


        // DELETE api/<TabEstadoController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            TabEstadoModel tabEstado = new TabEstadoModel { IdEstado = id };
            var result = TabEstadoService.DeteleTabEstado(tabEstado);

            if (result)
            {
                return "Entidad eliminada con exito.";
            }
            return "Hubo un error al eliminar la entidad.";

        }
    }
}
