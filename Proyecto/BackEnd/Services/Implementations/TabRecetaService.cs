using Backend.Services.Interfaces;
using Backend.Models;
using DAL.Interfaces;
using Entities.Entities;


namespace Backend.Services.Implementations 
{ 


    public class TabRecetaService : ITabRecetaService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public TabRecetaService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }



        public bool AddTabReceta(TabRecetaModel TabReceta)
        {
            TabReceta entity = Convertir(TabReceta);
            _unidadDeTrabajo._tabRecetaDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        TabRecetaModel Convertir(TabReceta tabReceta)
        {
            return new TabRecetaModel
            {
                IdReceta = tabReceta.IdReceta,
                NomReceta = tabReceta.NomReceta,
                Duracion = tabReceta.Duracion,
                Porciones = tabReceta.Porciones,
                FechaCreacion = tabReceta.FechaCreacion,
                IdEstado = tabReceta.IdEstado
            };
        }

        TabReceta Convertir(TabRecetaModel tabReceta)
        {
            return new TabReceta
            {
                IdReceta = tabReceta.IdReceta,
                NomReceta = tabReceta.NomReceta,
                Duracion = tabReceta.Duracion,
                Porciones = tabReceta.Porciones,
                FechaCreacion = tabReceta.FechaCreacion,
                IdEstado = tabReceta.IdEstado
                
            };
        }
        public bool DeteleTabReceta(TabRecetaModel tabReceta)
        {
            TabReceta entity = Convertir(tabReceta);
            _unidadDeTrabajo._tabRecetaDAL.Remove(entity);
            return _unidadDeTrabajo.Complete();
        }

        public TabRecetaModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._tabRecetaDAL.Get(id);

            TabRecetaModel tabRecetaModel = Convertir(entity);
            return tabRecetaModel;
        }

        public IEnumerable<TabRecetaModel> GetTabRecetas()
        {

            var result = _unidadDeTrabajo._tabRecetaDAL.GetAll();
            List<TabRecetaModel> lista = new List<TabRecetaModel>();
            foreach (var tabReceta in result)
            {
                lista.Add(Convertir(tabReceta));


            }
            return lista;
        }

        public bool UpdateTabReceta(TabRecetaModel tabReceta)
        {
            TabReceta entity = Convertir(tabReceta);
            _unidadDeTrabajo._tabRecetaDAL.Update(entity);
            return _unidadDeTrabajo.Complete();
        }

    }
}
