using Backend.Models;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabProfesoresController : ControllerBase
    {

        ITabProfesorService TabProfesorService;

        public TabProfesoresController(ITabProfesorService tabProfesorService)
        {
            TabProfesorService = tabProfesorService;
        }

        // GET: api/<TabProfesorController>
        [HttpGet]
        public IEnumerable<TabProfesorModel> Get()
        {
            return TabProfesorService.GetTabProfesores();
        }

        // GET api/<TabProfesorController>/5
        [HttpGet("{id}")]
        public TabProfesorModel Get(int id)
        {
            return TabProfesorService.GetById(id);
        }

        // POST api/<TabProfesorController>
        [HttpPost]
        public string Post([FromBody] TabProfesorModel tabProfesor)
        {
            var result = TabProfesorService.AddTabProfesor(tabProfesor);

            if (result)
            {
                return "Entidad agregada con exito.";
            }
            return "Hubo un error al agregar la entidad.";

        }

        // PUT api/<TabProfesorController>/5
        [HttpPut]
        public string Put([FromBody] TabProfesorModel tabProfesor)
        {
            var result = TabProfesorService.UpdateTabProfesor(tabProfesor);

            if (result)
            {
                return "Entidad editada con éxito.";
            }
            return "Hubo un error al editar la entidad.";
        }


        // DELETE api/<TabProfesorController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            TabProfesorModel tabProfesor = new TabProfesorModel { IdProfesor = id };
            var result = TabProfesorService.DeteleTabProfesor(tabProfesor);

            if (result)
            {
                return "Entidad eliminada con exito.";
            }
            return "Hubo un error al eliminar la entidad.";

        }
    }
}
