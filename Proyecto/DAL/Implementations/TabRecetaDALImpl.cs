using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class TabRecetaDALImpl : DALGenericoImpl<TabReceta>, ITabRecetaDAL
    {
        PrograWebContext _context;

        public TabRecetaDALImpl(PrograWebContext context) : base(context)
        {
            _context = context;
        }

    }
}
