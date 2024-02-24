using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{

    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public ITabEstadoDAL _tabEstadoDAL { get; }
        public ITabEstudianteDAL _tabEstudianteDAL { get; }
        public ITabHorarioDAL _tabHorarioDAL { get; }
        public ITabIngredienteDAL _tabIngredienteDAL { get; }
        public ITabInstruccionDAL _tabInstruccionDAL { get; }
        public ITabMatriculaDAL _tabMatriculaDAL { get; }
        public ITabProfesorDAL _tabProfesorDAL { get; }
        public ITabRecetaDAL _tabRecetaDAL { get; }
        public ITabCurso _tabCursoDAL { get; }
        public ITabCursoImpartir _tabCursoImpartirDAL { get; }


        private readonly PrograWebContext _context;

        public UnidadDeTrabajo(PrograWebContext quizContext, ITabEstadoDAL tabEstadoDAL,
            ITabEstudianteDAL tabEstudianteDAL, ITabHorarioDAL tabHorarioDAL, ITabIngredienteDAL tabIngredienteDAL,
            ITabInstruccionDAL tabInstruccionDAL, ITabMatriculaDAL tabMatriculaDAL, ITabProfesorDAL tabProfesorDAL,
            ITabRecetaDAL tabRecetaDAL, ITabCurso tabCursoDAL, ITabCursoImpartir tabCursoImpartirDAL)
        {
            _context = quizContext;
            _tabEstadoDAL = tabEstadoDAL;
            _tabEstudianteDAL = tabEstudianteDAL;
            _tabHorarioDAL = tabHorarioDAL;
            _tabIngredienteDAL = tabIngredienteDAL;
            _tabInstruccionDAL = tabInstruccionDAL;
            _tabMatriculaDAL = tabMatriculaDAL;
            _tabProfesorDAL = tabProfesorDAL;
            _tabRecetaDAL = tabRecetaDAL;
            _tabCursoDAL = tabCursoDAL;
            _tabCursoImpartirDAL = tabCursoImpartirDAL;
        }

        public bool Complete()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
