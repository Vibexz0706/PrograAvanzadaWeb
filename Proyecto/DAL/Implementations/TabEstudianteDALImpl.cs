using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class TabEstudianteDALImpl : DALGenericoImpl<TabEstudiante>, ITabEstudianteDAL
    {
        PrograWebContext _context;

        public TabEstudianteDALImpl(PrograWebContext context) : base(context)
        {
            _context = context;
        }

    }
}
