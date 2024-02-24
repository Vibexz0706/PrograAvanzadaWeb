using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
	public class UnidadDeTrabajo : IUnidadDeTrabajo
	{

		public ITabCurso _tabCursoDAL { get; }
		public ITabCursoImpartir _tabCursoImpartirDAL { get; }

		private readonly PrograWebContext _context;

		public UnidadDeTrabajo(PrograWebContext prograWebContext,
								ITabCurso tabCursoDAL,
								ITabCursoImpartir tabCursoImpartirDAL
								)
		{
			_context = prograWebContext;
			_tabCursoDAL = tabCursoDAL;
			_tabCursoImpartirDAL = tabCursoImpartirDAL;
		}


		public bool Complete()
		{
			try
			{
				_context.SaveChanges();
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
