using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class TabInstruccionDALImpl : DALGenericoImpl<TabInstruccion>, ITabInstruccionDAL
    {
        PrograWebContext _context;

        public TabInstruccionDALImpl(PrograWebContext context) : base(context)
        {
            _context = context;
        }

    }
}
