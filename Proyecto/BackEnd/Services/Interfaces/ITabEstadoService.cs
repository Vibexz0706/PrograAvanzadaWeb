

using Backend.Models;

namespace Backend.Services.Interfaces
{
    public interface ITabEstadoService
    {
        IEnumerable<TabEstadoModel> GetTabEstados();
        TabEstadoModel GetById(int id);
        bool AddTabEstado(TabEstadoModel tabEstado);
        bool UpdateTabEstado(TabEstadoModel tabEstado);
        bool DeteleTabEstado(TabEstadoModel tabEstado);
    }
}
