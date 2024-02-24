using Backend.Services.Interfaces;
using Backend.Models;
using DAL.Interfaces;
using Entities.Entities;


namespace Backend.Services.Implementations 
{ 


    public class TabMatriculaService : ITabMatriculaService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public TabMatriculaService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }



        public bool AddTabMatricula(TabMatriculaModel TabMatricula)
        {
            TabMatricula entity = Convertir(TabMatricula);
            _unidadDeTrabajo._tabMatriculaDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        TabMatriculaModel Convertir(TabMatricula tabMatricula)
        {
            return new TabMatriculaModel
            {
                IdMatricula = tabMatricula.IdMatricula,
                IdEstudiante = tabMatricula.IdEstudiante,
                IdCurso = tabMatricula.IdCurso
            };
        }

        TabMatricula Convertir(TabMatriculaModel tabMatricula)
        {
            return new TabMatricula
            {
                IdMatricula = tabMatricula.IdMatricula,
                IdEstudiante = tabMatricula.IdEstudiante,
                IdCurso = tabMatricula.IdCurso
            };
        }
        public bool DeteleTabMatricula(TabMatriculaModel tabMatricula)
        {
            TabMatricula entity = Convertir(tabMatricula);
            _unidadDeTrabajo._tabMatriculaDAL.Remove(entity);
            return _unidadDeTrabajo.Complete();
        }

        public TabMatriculaModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._tabMatriculaDAL.Get(id);

            TabMatriculaModel tabMatriculaModel = Convertir(entity);
            return tabMatriculaModel;
        }

        public IEnumerable<TabMatriculaModel> GetTabMatriculas()
        {

            var result = _unidadDeTrabajo._tabMatriculaDAL.GetAll();
            List<TabMatriculaModel> lista = new List<TabMatriculaModel>();
            foreach (var tabMatricula in result)
            {
                lista.Add(Convertir(tabMatricula));


            }
            return lista;
        }

        public bool UpdateTabMatricula(TabMatriculaModel tabMatricula)
        {
            TabMatricula entity = Convertir(tabMatricula);
            _unidadDeTrabajo._tabMatriculaDAL.Update(entity);
            return _unidadDeTrabajo.Complete();
        }

    }
}
