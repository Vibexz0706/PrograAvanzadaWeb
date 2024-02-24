

using Backend.Models;

namespace Backend.Services.Interfaces
{
    public interface ITabHorarioService
    {
        IEnumerable<TabHorarioModel> GetTabHorarios();
        TabHorarioModel GetById(int id);
        bool AddTabHorario(TabHorarioModel tabHorario);
        bool UpdateTabHorario(TabHorarioModel tabHorario);
        bool DeteleTabHorario(TabHorarioModel tabHorario);
    }
}
