using Backend.Services.Interfaces;
using Backend.Models;
using DAL.Interfaces;
using Entities.Entities;


namespace Backend.Services.Implementations 
{ 


    public class TabInstruccionService : ITabInstruccionService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public TabInstruccionService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }



        public bool AddTabInstruccion(TabInstruccionModel TabInstruccion)
        {
            TabInstruccion entity = Convertir(TabInstruccion);
            _unidadDeTrabajo._tabInstruccionDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        TabInstruccionModel Convertir(TabInstruccion tabInstruccion)
        {
            return new TabInstruccionModel
            {
                IdInstrucciones = tabInstruccion.IdInstrucciones,
                IdReceta = tabInstruccion.IdReceta,
                Instruccion = tabInstruccion.Instruccion
            };
        }

        TabInstruccion Convertir(TabInstruccionModel tabInstruccion)
        {
            return new TabInstruccion
            {
                IdInstrucciones = tabInstruccion.IdInstrucciones,
                IdReceta = tabInstruccion.IdReceta,
                Instruccion = tabInstruccion.Instruccion
            };
        }
        public bool DeteleTabInstruccion(TabInstruccionModel tabInstruccion)
        {
            TabInstruccion entity = Convertir(tabInstruccion);
            _unidadDeTrabajo._tabInstruccionDAL.Remove(entity);
            return _unidadDeTrabajo.Complete();
        }

        public TabInstruccionModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._tabInstruccionDAL.Get(id);

            TabInstruccionModel tabInstruccionModel = Convertir(entity);
            return tabInstruccionModel;
        }

        public IEnumerable<TabInstruccionModel> GetTabInstrucciones()
        {

            var result = _unidadDeTrabajo._tabInstruccionDAL.GetAll();
            List<TabInstruccionModel> lista = new List<TabInstruccionModel>();
            foreach (var tabInstruccion in result)
            {
                lista.Add(Convertir(tabInstruccion));


            }
            return lista;
        }

        public bool UpdateTabInstruccion(TabInstruccionModel tabInstruccion)
        {
            TabInstruccion entity = Convertir(tabInstruccion);
            _unidadDeTrabajo._tabInstruccionDAL.Update(entity);
            return _unidadDeTrabajo.Complete();
        }

    }
}
