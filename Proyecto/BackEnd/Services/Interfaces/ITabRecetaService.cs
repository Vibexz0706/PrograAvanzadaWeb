

using Backend.Models;

namespace Backend.Services.Interfaces
{
    public interface ITabRecetaService
    {
        IEnumerable<TabRecetaModel> GetTabRecetas();
        TabRecetaModel GetById(int id);
        bool AddTabReceta(TabRecetaModel tabReceta);
        bool UpdateTabReceta(TabRecetaModel tabReceta);
        bool DeteleTabReceta(TabRecetaModel tabReceta);
    }
}
