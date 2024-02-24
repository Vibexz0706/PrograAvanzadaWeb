using Backend.Services.Interfaces;
using Backend.Models;
using DAL.Interfaces;
using Entities.Entities;


namespace Backend.Services.Implementations 
{ 


    public class TabHorarioService : ITabHorarioService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public TabHorarioService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }



        public bool AddTabHorario(TabHorarioModel TabHorario)
        {
            TabHorario entity = Convertir(TabHorario);
            _unidadDeTrabajo._tabHorarioDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        TabHorarioModel Convertir(TabHorario tabHorario)
        {
            return new TabHorarioModel
            {
                IdHorario = tabHorario.IdHorario,
                Horario = tabHorario.Horario
            };
        }

        TabHorario Convertir(TabHorarioModel tabHorario)
        {
            return new TabHorario
            {
                IdHorario = tabHorario.IdHorario,
                Horario = tabHorario.Horario
            };
        }
        public bool DeteleTabHorario(TabHorarioModel tabHorario)
        {
            TabHorario entity = Convertir(tabHorario);
            _unidadDeTrabajo._tabHorarioDAL.Remove(entity);
            return _unidadDeTrabajo.Complete();
        }

        public TabHorarioModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._tabHorarioDAL.Get(id);

            TabHorarioModel tabHorarioModel = Convertir(entity);
            return tabHorarioModel;
        }

        public IEnumerable<TabHorarioModel> GetTabHorarios()
        {

            var result = _unidadDeTrabajo._tabHorarioDAL.GetAll();
            List<TabHorarioModel> lista = new List<TabHorarioModel>();
            foreach (var tabHorario in result)
            {
                lista.Add(Convertir(tabHorario));


            }
            return lista;
        }

        public bool UpdateTabHorario(TabHorarioModel tabHorario)
        {
            TabHorario entity = Convertir(tabHorario);
            _unidadDeTrabajo._tabHorarioDAL.Update(entity);
            return _unidadDeTrabajo.Complete();
        }

    }
}
