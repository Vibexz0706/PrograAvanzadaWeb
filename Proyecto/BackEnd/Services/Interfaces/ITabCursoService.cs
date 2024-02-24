using BackEnd.Models;

namespace BackEnd.Services.Interfaces
{
	public interface ITabCursoService
	{
		IEnumerable<TabCursoModel> GetTabCurso();
		TabCursoModel GetById(int id);
		bool AddTabCurso(TabCursoModel TabCurso);
		bool UpdateTabCurso(TabCursoModel TabCurso);
		bool DeteleTabCurso(TabCursoModel TabCurso);


	}
}
