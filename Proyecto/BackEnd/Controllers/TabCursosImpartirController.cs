using BackEnd.Services.Interfaces;
using BackEnd.Models;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using BackEnd.Services.Implementations;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TabCursosImpartirController : ControllerBase
	{

		ITabCursoImpartirService TabCursoImpartirService;

        public TabCursoImpartirsController(ITabCursoImpartirService tabCursoImpartirService)
        {
			TabCursoImpartirService = tabCursoImpartirService;
        }

		// GET: api/<TabCursoImpartirController>
		[HttpGet]
        public IEnumerable<TabCursoImpartirModel> Get()
        {
            return TabCursoImpartirService.GetTabCursosImpartir();
        }

		// GET api/<TabCursoImpartirController>/5
		[HttpGet("{id}")]
        public TabCursoImpartirModel Get(int id)
        {
            return TabCursoImpartirService.GetById(id);
        }

        // POST api/<TabCursoImpartirController>
        [HttpPost]
        public string Post([FromBody] TabCursoImpartirModel tabCursoImpartir)
        {
            var result = TabCursoImpartirService.AddTabCursoImpartir(tabCursoImpartir);

            if (result)
            {
                return "Curso impartido agregado con exito.";
            }
            return "Hubo un error al agregar el curso impartido.";

        }

		// PUT api/<TabCursoImpartirController>/5
		[HttpPut]
        public string Put([FromBody] TabCursoImpartirModel tabCursoImpartir)
        {
            var result = TabCursoImpartirService.UpdateTabCursoImpartir(tabCursoImpartir);

            if (result)
            {
                return "Curso impartido editado con éxito.";
            }
            return "Hubo un error al editar el curso impartido.";
        }


		// DELETE api/<TabCursoImpartirController>/5
		[HttpDelete("{id}")]
        public string Delete(int id)
        {

			TabCursoImpartirModel tabCursoImpartir = new TabCursoImpartirModel { IdCursoImpartir = id };
            var result = TabCursoImpartirService.DeteleTabCursoImpartir(tabCursoImpartir);

            if (result)
            {
                return "Curso impartido eliminado con exito.";
            }
            return "Hubo un error al eliminar el curso impartido.";

        }
    }
}
