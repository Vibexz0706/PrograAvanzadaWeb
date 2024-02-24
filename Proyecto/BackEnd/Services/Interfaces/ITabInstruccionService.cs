

using Backend.Models;

namespace Backend.Services.Interfaces
{
    public interface ITabInstruccionService
    {
        IEnumerable<TabInstruccionModel> GetTabInstrucciones();
        TabInstruccionModel GetById(int id);
        bool AddTabInstruccion(TabInstruccionModel tabInstruccion);
        bool UpdateTabInstruccion(TabInstruccionModel tabInstruccion);
        bool DeteleTabInstruccion(TabInstruccionModel tabInstruccion);
    }
}
