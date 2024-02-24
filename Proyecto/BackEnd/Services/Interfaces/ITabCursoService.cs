using BackEnd.Models;

namespace BackEnd.Services.Interfaces
{
	public interface ITabCursoService
	{
		IEnumerable<TabCursoModel> GetCurso();
		TabCursoModel GetById(int id);
		bool AddCurso(TabCursoModel curso);
		bool UpdateCurso(TabCursoModel curso);
		bool DeteleCurso(TabCursoModel curso);


	}
}
