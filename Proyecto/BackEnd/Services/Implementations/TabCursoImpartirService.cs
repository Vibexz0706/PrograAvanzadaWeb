using BackEnd.Models;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
	public class TabCursoImpartirService : ITabCursoImpartirService
	{

		public IUnidadDeTrabajo _unidadDeTrabajo;

		public TabCursoImpartirService(IUnidadDeTrabajo unidadDeTrabajo)
		{
			_unidadDeTrabajo = unidadDeTrabajo;
		}



		public bool AddTabCursoImpartir(TabCursoImpartirModel TabCursoImpartir)
		{
			TabCursoImpartir entity = Convertir(TabCursoImpartir);
			_unidadDeTrabajo._tabCursoImpartirDAL.Add(entity);
			return _unidadDeTrabajo.Complete();
		}

		TabCursoImpartirModel Convertir(TabCursoImpartir tabCursoImpartir)
		{
			return new TabCursoImpartirModel
			{
				IdCursoImpartir = tabCursoImpartir.IdCursoImpartir,
				IdCurso = tabCursoImpartir.IdCurso,
				IdProfesor = tabCursoImpartir.IdProfesor,
				IdProfesorNavigation=tabCursoImpartir.IdProfesorNavigation
			};
		}

		TabCursoImpartir Convertir(TabCursoImpartirModel tabCursoImpartir)
		{
			return new TabCursoImpartir
			{
				IdCursoImpartir = tabCursoImpartir.IdCursoImpartir,
				IdCurso = tabCursoImpartir.IdCurso,
				IdProfesor = tabCursoImpartir.IdProfesor
			};
		}
		public bool DeteleTabCursoImpartir(TabCursoImpartirModel tabCursoImpartir)
		{
			TabCursoImpartir entity = Convertir(tabCursoImpartir);
			_unidadDeTrabajo._tabCursoImpartirDAL.Remove(entity);
			return _unidadDeTrabajo.Complete();
		}

		public TabCursoImpartirModel GetById(int id)
		{
			var entity = _unidadDeTrabajo._tabCursoImpartirDAL.Get(id);

			TabCursoImpartirModel tabCursoImpartirModel = Convertir(entity);
			return tabCursoImpartirModel;
		}

		public IEnumerable<TabCursoImpartirModel> GetTabCursosImpartir()
		{

			var result = _unidadDeTrabajo._tabCursoImpartirDAL.GetAll();
			List<TabCursoImpartirModel> lista = new List<TabCursoImpartirModel>();
			foreach (var tabCursoImpartir in result)
			{
				lista.Add(Convertir(tabCursoImpartir));


			}
			return lista;
		}

		public bool UpdateTabCursoImpartir(TabCursoImpartirModel tabCursoImpartir)
		{
			TabCursoImpartir entity = Convertir(tabCursoImpartir);
			_unidadDeTrabajo._tabCursoImpartirDAL.Update(entity);
			return _unidadDeTrabajo.Complete();
		}

        
    }
}
