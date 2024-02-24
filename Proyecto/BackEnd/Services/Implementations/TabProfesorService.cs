using Backend.Services.Interfaces;
using Backend.Models;
using DAL.Interfaces;
using Entities.Entities;


namespace Backend.Services.Implementations 
{ 


    public class TabProfesorService : ITabProfesorService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public TabProfesorService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }



        public bool AddTabProfesor(TabProfesorModel TabProfesor)
        {
            TabProfesor entity = Convertir(TabProfesor);
            _unidadDeTrabajo._tabProfesorDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        TabProfesorModel Convertir(TabProfesor tabProfesor)
        {
            return new TabProfesorModel
            {
                IdProfesor = tabProfesor.IdProfesor,
                Cedula = tabProfesor.Cedula,
                Nombre = tabProfesor.Nombre,
                ApellidoMat = tabProfesor.ApellidoMat,
                ApellidoPat = tabProfesor.ApellidoPat,
                Correo = tabProfesor.Correo,
                FechaNacimiento = tabProfesor.FechaNacimiento
            };
        }

        TabProfesor Convertir(TabProfesorModel tabProfesor)
        {
            return new TabProfesor
            {
                IdProfesor = tabProfesor.IdProfesor,
                Cedula = tabProfesor.Cedula,
                Nombre = tabProfesor.Nombre,
                ApellidoMat = tabProfesor.ApellidoMat,
                ApellidoPat = tabProfesor.ApellidoPat,
                Correo = tabProfesor.Correo,
                FechaNacimiento = tabProfesor.FechaNacimiento
            };
        }
        public bool DeteleTabProfesor(TabProfesorModel tabProfesor)
        {
            TabProfesor entity = Convertir(tabProfesor);
            _unidadDeTrabajo._tabProfesorDAL.Remove(entity);
            return _unidadDeTrabajo.Complete();
        }

        public TabProfesorModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._tabProfesorDAL.Get(id);

            TabProfesorModel tabProfesorModel = Convertir(entity);
            return tabProfesorModel;
        }

        public IEnumerable<TabProfesorModel> GetTabProfesores()
        {

            var result = _unidadDeTrabajo._tabProfesorDAL.GetAll();
            List<TabProfesorModel> lista = new List<TabProfesorModel>();
            foreach (var tabProfesor in result)
            {
                lista.Add(Convertir(tabProfesor));


            }
            return lista;
        }

        public bool UpdateTabProfesor(TabProfesorModel tabProfesor)
        {
            TabProfesor entity = Convertir(tabProfesor);
            _unidadDeTrabajo._tabProfesorDAL.Update(entity);
            return _unidadDeTrabajo.Complete();
        }

    }
}
