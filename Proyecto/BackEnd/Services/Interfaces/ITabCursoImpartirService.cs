using BackEnd.Models;

namespace BackEnd.Services.Interfaces
{
	public interface ITabCursoImpartirService
	{
		IEnumerable<TabCursoImpartirModel> GetCursoImpartir();
		TabCursoImpartirModel GetById(int id);
		bool AddCursoImpartir(TabCursoImpartirModel cursoImpartir);
		bool UpdateCursoImpartir(TabCursoImpartirModel cursoImpartir);
		bool DeteleCursoImpartir(TabCursoImpartirModel cursoImpartir);


	}
}