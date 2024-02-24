

using Backend.Models;

namespace Backend.Services.Interfaces
{
    public interface ITabMatriculaService
    {
        IEnumerable<TabMatriculaModel> GetTabMatriculas();
        TabMatriculaModel GetById(int id);
        bool AddTabMatricula(TabMatriculaModel tabMatricula);
        bool UpdateTabMatricula(TabMatriculaModel tabMatricula);
        bool DeteleTabMatricula(TabMatriculaModel tabMatricula);
    }
}
