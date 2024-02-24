using Backend.Services.Interfaces;
using Backend.Models;
using DAL.Interfaces;
using Entities.Entities;


namespace Backend.Services.Implementations 
{ 


    public class TabEstudianteService : ITabEstudianteService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public TabEstudianteService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }



        public bool AddTabEstudiante(TabEstudianteModel TabEstudiante)
        {
            TabEstudiante entity = Convertir(TabEstudiante);
            _unidadDeTrabajo._tabEstudianteDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        TabEstudianteModel Convertir(TabEstudiante tabEstudiante)
        {
            return new TabEstudianteModel
            {
                IdEstudiante = tabEstudiante.IdEstudiante,      
                Cedula = tabEstudiante.Cedula,
                Nombre = tabEstudiante.Nombre,
                ApellidoPat = tabEstudiante.ApellidoPat,
                ApellidoMat = tabEstudiante.ApellidoMat,
                Correo = tabEstudiante.Correo,
                FechaNacimiento = tabEstudiante.FechaNacimiento,
                
            };
        }

        TabEstudiante Convertir(TabEstudianteModel tabEstudiante)
        {
            return new TabEstudiante
            {
                IdEstudiante = tabEstudiante.IdEstudiante,
                Cedula = tabEstudiante.Cedula,
                Nombre = tabEstudiante.Nombre,
                ApellidoPat = tabEstudiante.ApellidoPat,
                ApellidoMat = tabEstudiante.ApellidoMat,
                Correo = tabEstudiante.Correo,
                FechaNacimiento = tabEstudiante.FechaNacimiento,
            };
        }
        public bool DeteleTabEstudiante(TabEstudianteModel tabEstudiante)
        {
            TabEstudiante entity = Convertir(tabEstudiante);
            _unidadDeTrabajo._tabEstudianteDAL.Remove(entity);
            return _unidadDeTrabajo.Complete();
        }

        public TabEstudianteModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._tabEstudianteDAL.Get(id);

            TabEstudianteModel tabEstudianteModel = Convertir(entity);
            return tabEstudianteModel;
        }

        public IEnumerable<TabEstudianteModel> GetTabEstudiantes()
        {

            var result = _unidadDeTrabajo._tabEstudianteDAL.GetAll();
            List<TabEstudianteModel> lista = new List<TabEstudianteModel>();
            foreach (var tabEstudiante in result)
            {
                lista.Add(Convertir(tabEstudiante));


            }
            return lista;
        }

        public bool UpdateTabEstudiante(TabEstudianteModel tabEstudiante)
        {
            TabEstudiante entity = Convertir(tabEstudiante);
            _unidadDeTrabajo._tabEstudianteDAL.Update(entity);
            return _unidadDeTrabajo.Complete();
        }

    }
}
