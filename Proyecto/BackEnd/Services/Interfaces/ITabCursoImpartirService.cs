using BackEnd.Models;

namespace BackEnd.Services.Interfaces
{
	public interface ITabCursoImpartirService
	{
		IEnumerable<TabCursoImpartirModel> GetTabCursosImpartir();
		TabCursoImpartirModel GetById(int id);
		bool AddTabCursoImpartir(TabCursoImpartirModel tabCursoImpartir);
		bool UpdateTabCursoImpartir(TabCursoImpartirModel tabCursoImpartir);
		bool DeteleTabCursoImpartir(TabCursoImpartirModel tabCursoImpartir);


	}
}