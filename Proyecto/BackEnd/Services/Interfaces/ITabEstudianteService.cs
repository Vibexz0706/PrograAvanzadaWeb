

using Backend.Models;

namespace Backend.Services.Interfaces
{
    public interface ITabEstudianteService
    {
        IEnumerable<TabEstudianteModel> GetTabEstudiantes();
        TabEstudianteModel GetById(int id);
        bool AddTabEstudiante(TabEstudianteModel tabEstudiante);
        bool UpdateTabEstudiante(TabEstudianteModel tabEstudiante);
        bool DeteleTabEstudiante(TabEstudianteModel tabEstudiante);
    }
}
