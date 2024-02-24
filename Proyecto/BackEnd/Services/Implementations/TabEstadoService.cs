using Backend.Services.Interfaces;
using Backend.Models;
using DAL.Interfaces;
using Entities.Entities;


namespace Backend.Services.Implementations 
{ 


    public class TabEstadoService : ITabEstadoService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public TabEstadoService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }



        public bool AddTabEstado(TabEstadoModel TabEstado)
        {
            TabEstado entity = Convertir(TabEstado);
            _unidadDeTrabajo._tabEstadoDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        TabEstadoModel Convertir(TabEstado tabEstado)
        {
            return new TabEstadoModel
            {
                IdEstado = tabEstado.IdEstado,
                Estado = tabEstado.Estado
            };
        }

        TabEstado Convertir(TabEstadoModel tabEstado)
        {
            return new TabEstado
            {
                IdEstado = tabEstado.IdEstado,
                Estado = tabEstado.Estado
            };
        }
        public bool DeteleTabEstado(TabEstadoModel tabEstado)
        {
            TabEstado entity = Convertir(tabEstado);
            _unidadDeTrabajo._tabEstadoDAL.Remove(entity);
            return _unidadDeTrabajo.Complete();
        }

        public TabEstadoModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._tabEstadoDAL.Get(id);

            TabEstadoModel tabEstadoModel = Convertir(entity);
            return tabEstadoModel;
        }

        public IEnumerable<TabEstadoModel> GetTabEstados()
        {

            var result = _unidadDeTrabajo._tabEstadoDAL.GetAll();
            List<TabEstadoModel> lista = new List<TabEstadoModel>();
            foreach (var tabEstado in result)
            {
                lista.Add(Convertir(tabEstado));


            }
            return lista;
        }

        public bool UpdateTabEstado(TabEstadoModel tabEstado)
        {
            TabEstado entity = Convertir(tabEstado);
            _unidadDeTrabajo._tabEstadoDAL.Update(entity);
            return _unidadDeTrabajo.Complete();
        }

    }
}
