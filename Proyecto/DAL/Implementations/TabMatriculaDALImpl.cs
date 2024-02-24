using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class TabMatriculaDALImpl : DALGenericoImpl<TabMatricula>, ITabMatriculaDAL
    {
        PrograWebContext _context;

        public TabMatriculaDALImpl(PrograWebContext context) : base(context)
        {
            _context = context;
        }

    }
}
