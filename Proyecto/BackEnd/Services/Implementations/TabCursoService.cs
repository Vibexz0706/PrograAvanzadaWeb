using BackEnd.Models;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
	public class TabCursoService : ITabCursoService
	{

		public IUnidadDeTrabajo _unidadDeTrabajo;

		public TabCursoService(IUnidadDeTrabajo unidadDeTrabajo)
		{
			_unidadDeTrabajo = unidadDeTrabajo;
		}



		public bool AddTabCurso(TabCursoModel TabCurso)
		{
			TabCurso entity = Convertir(TabCurso);
			_unidadDeTrabajo._tabCursoDAL.Add(entity);
			return _unidadDeTrabajo.Complete();
		}

		TabCursoModel Convertir(TabCurso tabCurso)
		{
			return new TabCursoModel
			{
				IdCurso = tabCurso.IdCurso,
				Curso = tabCurso.Curso,
				FechaInicio = tabCurso.FechaInicio,
				FechaFin = tabCurso.FechaFin,
				IdEstado = tabCurso.IdEstado,
				IdHorario = tabCurso.IdHorario,
				IdEstadoNavigation = tabCurso.IdEstadoNavigation,
				IdHorarioNavigation = tabCurso.IdHorarioNavigation,
				TabMatriculas=tabCurso.TabMatriculas
			};
		}

		TabCurso Convertir(TabCursoModel tabCurso)
		{
			return new TabCurso
			{
				IdCurso = tabCurso.IdCurso,
				Curso = tabCurso.Curso,
				FechaInicio = tabCurso.FechaInicio,
				FechaFin = tabCurso.FechaFin,
				IdEstado = tabCurso.IdEstado,
				IdHorario = tabCurso.IdHorario,
				IdEstadoNavigation = tabCurso.IdEstadoNavigation,
				IdHorarioNavigation = tabCurso.IdHorarioNavigation,
				TabMatriculas = tabCurso.TabMatriculas
			};
		}
		public bool DeteleTabCurso(TabCursoModel tabCurso)
		{
			TabCurso entity = Convertir(tabCurso);
			_unidadDeTrabajo._tabCursoDAL.Remove(entity);
			return _unidadDeTrabajo.Complete();
		}

		public TabCursoModel GetById(int id)
		{
			var entity = _unidadDeTrabajo._tabCursoDAL.Get(id);

			TabCursoModel tabCursoModel = Convertir(entity);
			return tabCursoModel;
		}

		public IEnumerable<TabCursoModel> GetTabCursos()
		{

			var result = _unidadDeTrabajo._tabCursoDAL.GetAll();
			List<TabCursoModel> lista = new List<TabCursoModel>();
			foreach (var tabCurso in result)
			{
				lista.Add(Convertir(tabCurso));


			}
			return lista;
		}

		public bool UpdateTabCurso(TabCursoModel tabCurso)
		{
			TabCurso entity = Convertir(tabCurso);
			_unidadDeTrabajo._tabCursoDAL.Update(entity);
			return _unidadDeTrabajo.Complete();
		}

	}
}