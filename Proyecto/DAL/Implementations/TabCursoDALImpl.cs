using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
	public class TabCursoDALImpl : DALGenericoImpl<TabCurso>, ITabCurso
	{
		PrograWebContext _context;

		public TabCursoDALImpl(PrograWebContext context) : base(context)
		{
			_context = context;
		}


	}
}

