using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class TabEstadoDALImpl : DALGenericoImpl<TabEstado>, ITabEstadoDAL
    {
        PrograWebContext _context;

        public TabEstadoDALImpl(PrograWebContext context) : base(context)
        {
            _context = context;
        }

    }
}
