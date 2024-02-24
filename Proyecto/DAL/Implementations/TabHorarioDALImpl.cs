using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class TabHorarioDALImpl : DALGenericoImpl<TabHorario>, ITabHorarioDAL
    {
        PrograWebContext _context;

        public TabHorarioDALImpl(PrograWebContext context) : base(context)
        {
            _context = context;
        }

    }
}
