using Backend.Models;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabMatriculasController : ControllerBase
    {

        ITabMatriculaService TabMatriculaService;

        public TabMatriculasController(ITabMatriculaService tabMatriculaService)
        {
            TabMatriculaService = tabMatriculaService;
        }

        // GET: api/<TabMatriculaController>
        [HttpGet]
        public IEnumerable<TabMatriculaModel> Get()
        {
            return TabMatriculaService.GetTabMatriculas();
        }

        // GET api/<TabMatriculaController>/5
        [HttpGet("{id}")]
        public TabMatriculaModel Get(int id)
        {
            return TabMatriculaService.GetById(id);
        }

        // POST api/<TabMatriculaController>
        [HttpPost]
        public string Post([FromBody] TabMatriculaModel tabMatricula)
        {
            var result = TabMatriculaService.AddTabMatricula(tabMatricula);

            if (result)
            {
                return "Entidad agregada con exito.";
            }
            return "Hubo un error al agregar la entidad.";

        }

        // PUT api/<TabMatriculaController>/5
        [HttpPut]
        public string Put([FromBody] TabMatriculaModel tabMatricula)
        {
            var result = TabMatriculaService.UpdateTabMatricula(tabMatricula);

            if (result)
            {
                return "Entidad editada con éxito.";
            }
            return "Hubo un error al editar la entidad.";
        }


        // DELETE api/<TabMatriculaController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            TabMatriculaModel tabMatricula = new TabMatriculaModel { IdMatricula = id };
            var result = TabMatriculaService.DeteleTabMatricula(tabMatricula);

            if (result)
            {
                return "Entidad eliminada con exito.";
            }
            return "Hubo un error al eliminar la entidad.";

        }
    }
}
