using Backend.Models;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabHorariosController : ControllerBase
    {

        ITabHorarioService TabHorarioService;

        public TabHorariosController(ITabHorarioService tabHorarioService)
        {
            TabHorarioService = tabHorarioService;
        }

        // GET: api/<TabHorarioController>
        [HttpGet]
        public IEnumerable<TabHorarioModel> Get()
        {
            return TabHorarioService.GetTabHorarios();
        }

        // GET api/<TabHorarioController>/5
        [HttpGet("{id}")]
        public TabHorarioModel Get(int id)
        {
            return TabHorarioService.GetById(id);
        }

        // POST api/<TabHorarioController>
        [HttpPost]
        public string Post([FromBody] TabHorarioModel tabHorario)
        {
            var result = TabHorarioService.AddTabHorario(tabHorario);

            if (result)
            {
                return "Entidad agregada con exito.";
            }
            return "Hubo un error al agregar la entidad.";

        }

        // PUT api/<TabHorarioController>/5
        [HttpPut]
        public string Put([FromBody] TabHorarioModel tabHorario)
        {
            var result = TabHorarioService.UpdateTabHorario(tabHorario);

            if (result)
            {
                return "Entidad editada con éxito.";
            }
            return "Hubo un error al editar la entidad.";
        }


        // DELETE api/<TabHorarioController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            TabHorarioModel tabHorario = new TabHorarioModel { IdHorario = id };
            var result = TabHorarioService.DeteleTabHorario(tabHorario);

            if (result)
            {
                return "Entidad eliminada con exito.";
            }
            return "Hubo un error al eliminar la entidad.";

        }
    }
}
