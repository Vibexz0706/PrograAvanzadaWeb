using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class TabProfesorDALImpl : DALGenericoImpl<TabProfesor>, ITabProfesorDAL
    {
        PrograWebContext _context;

        public TabProfesorDALImpl(PrograWebContext context) : base(context)
        {
            _context = context;
        }

    }
}
