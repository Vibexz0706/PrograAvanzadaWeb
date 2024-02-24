using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class TabIngredienteDALImpl : DALGenericoImpl<TabIngrediente>, ITabIngredienteDAL
    {
        PrograWebContext _context;

        public TabIngredienteDALImpl(PrograWebContext context) : base(context)
        {
            _context = context;
        }

    }
}
