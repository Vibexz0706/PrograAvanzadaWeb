using Backend.Services.Interfaces;
using Backend.Models;
using DAL.Interfaces;
using Entities.Entities;


namespace Backend.Services.Implementations 
{ 


    public class TabIngredienteService : ITabIngredienteService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public TabIngredienteService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }



        public bool AddTabIngrediente(TabIngredienteModel TabIngrediente)
        {
            TabIngrediente entity = Convertir(TabIngrediente);
            _unidadDeTrabajo._tabIngredienteDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        TabIngredienteModel Convertir(TabIngrediente tabIngrediente)
        {
            return new TabIngredienteModel
            {
                IdIngredientes = tabIngrediente.IdIngredientes,
                IdReceta = tabIngrediente.IdReceta,
                Ingrediente = tabIngrediente.Ingrediente
            };
        }

        TabIngrediente Convertir(TabIngredienteModel tabIngrediente)
        {
            return new TabIngrediente
            {
                IdIngredientes = tabIngrediente.IdIngredientes,
                IdReceta = tabIngrediente.IdReceta,
                Ingrediente = tabIngrediente.Ingrediente
            };
        }
        public bool DeteleTabIngrediente(TabIngredienteModel tabIngrediente)
        {
            TabIngrediente entity = Convertir(tabIngrediente);
            _unidadDeTrabajo._tabIngredienteDAL.Remove(entity);
            return _unidadDeTrabajo.Complete();
        }

        public TabIngredienteModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._tabIngredienteDAL.Get(id);

            TabIngredienteModel tabIngredienteModel = Convertir(entity);
            return tabIngredienteModel;
        }

        public IEnumerable<TabIngredienteModel> GetTabIngredientes()
        {

            var result = _unidadDeTrabajo._tabIngredienteDAL.GetAll();
            List<TabIngredienteModel> lista = new List<TabIngredienteModel>();
            foreach (var tabIngrediente in result)
            {
                lista.Add(Convertir(tabIngrediente));


            }
            return lista;
        }

        public bool UpdateTabIngrediente(TabIngredienteModel tabIngrediente)
        {
            TabIngrediente entity = Convertir(tabIngrediente);
            _unidadDeTrabajo._tabIngredienteDAL.Update(entity);
            return _unidadDeTrabajo.Complete();
        }

    }
}
