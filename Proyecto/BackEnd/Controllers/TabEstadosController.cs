using Backend.Models;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabEstudiantesController : ControllerBase
    {

        ITabEstudianteService TabEstudianteService;

        public TabEstudiantesController(ITabEstudianteService tabEstudianteService)
        {
            TabEstudianteService = tabEstudianteService;
        }

        // GET: api/<TabEstudianteController>
        [HttpGet]
        public IEnumerable<TabEstudianteModel> Get()
        {
            return TabEstudianteService.GetTabEstudiantes();
        }

        // GET api/<TabEstudianteController>/5
        [HttpGet("{id}")]
        public TabEstudianteModel Get(int id)
        {
            return TabEstudianteService.GetById(id);
        }

        // POST api/<TabEstudianteController>
        [HttpPost]
        public string Post([FromBody] TabEstudianteModel tabEstudiante)
        {
            var result = TabEstudianteService.AddTabEstudiante(tabEstudiante);

            if (result)
            {
                return "Entidad agregada con exito.";
            }
            return "Hubo un error al agregar la entidad.";

        }

        // PUT api/<TabEstudianteController>/5
        [HttpPut]
        public string Put([FromBody] TabEstudianteModel tabEstudiante)
        {
            var result = TabEstudianteService.UpdateTabEstudiante(tabEstudiante);

            if (result)
            {
                return "Entidad editada con éxito.";
            }
            return "Hubo un error al editar la entidad.";
        }


        // DELETE api/<TabEstudianteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            TabEstudianteModel tabEstudiante = new TabEstudianteModel { IdEstudiante = id };
            var result = TabEstudianteService.DeteleTabEstudiante(tabEstudiante);

            if (result)
            {
                return "Entidad eliminada con exito.";
            }
            return "Hubo un error al eliminar la entidad.";

        }
    }
}
