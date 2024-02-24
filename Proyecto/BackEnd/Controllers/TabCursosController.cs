using BackEnd.Services.Interfaces;
using BackEnd.Models;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabCursosController : ControllerBase
    {

		ITabCursoService TabCursoService;

        public TabCursosController(ITabCursoService tabCursoService)
        {
			TabCursoService = tabCursoService;
        }

		// GET: api/<TabCursoController>
		[HttpGet]
        public IEnumerable<TabCursoModel> Get()
        {
            return TabCursoService.GetTabCursos();
        }

		// GET api/<TabCursoController>/5
		[HttpGet("{id}")]
        public TabCursoModel Get(int id)
        {
            return TabCursoService.GetById(id);
        }

        // POST api/<TabCursoController>
        [HttpPost]
        public string Post([FromBody] TabCursoModel tabCurso)
        {
            var result = TabCursoService.AddTabCurso(tabCurso);

            if (result)
            {
                return "Curso agregado con exito.";
            }
            return "Hubo un error al agregar el curso.";

        }

		// PUT api/<TabCursoController>/5
		[HttpPut]
        public string Put([FromBody] TabCursoModel tabCurso)
        {
            var result = TabCursoService.UpdateTabCurso(tabCurso);

            if (result)
            {
                return "Curso editado con éxito.";
            }
            return "Hubo un error al editar el curso.";
        }


		// DELETE api/<TabCursoController>/5
		[HttpDelete("{id}")]
        public string Delete(int id)
        {

			TabCursoModel tabCurso = new TabCursoModel { IdCurso = id };
            var result = TabCursoService.DeteleTabCurso(tabCurso);

            if (result)
            {
                return "Curso eliminado con exito.";
            }
            return "Hubo un error al eliminar el curso.";

        }
    }
}
