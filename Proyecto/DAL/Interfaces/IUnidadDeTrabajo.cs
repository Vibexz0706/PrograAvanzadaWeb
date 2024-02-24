using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IUnidadDeTrabajo : IDisposable
	{
		ITabCurso _tabCursoDAL { get; }
		ITabCursoImpartir _tabCursoImpartirDAL { get; }
		bool Complete();
	}
}
