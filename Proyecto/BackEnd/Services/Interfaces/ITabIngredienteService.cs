

using Backend.Models;

namespace Backend.Services.Interfaces
{
    public interface ITabIngredienteService
    {
        IEnumerable<TabIngredienteModel> GetTabIngredientes();
        TabIngredienteModel GetById(int id);
        bool AddTabIngrediente(TabIngredienteModel tabIngrediente);
        bool UpdateTabIngrediente(TabIngredienteModel tabIngrediente);
        bool DeteleTabIngrediente(TabIngredienteModel tabIngrediente);
    }
}
