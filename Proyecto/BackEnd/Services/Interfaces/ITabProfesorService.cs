

using Backend.Models;

namespace Backend.Services.Interfaces
{
    public interface ITabProfesorService
    {
        IEnumerable<TabProfesorModel> GetTabProfesores();
        TabProfesorModel GetById(int id);
        bool AddTabProfesor(TabProfesorModel tabProfesor);
        bool UpdateTabProfesor(TabProfesorModel tabProfesor);
        bool DeteleTabProfesor(TabProfesorModel tabProfesor);
    }
}
