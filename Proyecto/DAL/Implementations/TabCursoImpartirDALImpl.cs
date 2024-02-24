using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
	public class TabCursoImpartirDALImpl : DALGenericoImpl<TabCursoImpartir>, ITabCursoImpartir
	{
		PrograWebContext _context;

		public TabCursoImpartirDALImpl(PrograWebContext context) : base(context)
		{
			_context = context;
		}


	}
}
