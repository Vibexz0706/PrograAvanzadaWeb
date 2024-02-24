<<<<<<< HEAD
﻿using System;
=======
﻿using Entities.Entities;
using System;
>>>>>>> Gustavo
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
<<<<<<< HEAD
    public interface IUnidadDeTrabajo : IDisposable
    {

        ITabEstadoDAL _tabEstadoDAL { get; }   
        ITabEstudianteDAL _tabEstudianteDAL { get; }   
        ITabHorarioDAL _tabHorarioDAL { get; }   
        ITabIngredienteDAL _tabIngredienteDAL { get; }   
        ITabInstruccionDAL _tabInstruccionDAL { get; }   
        ITabMatriculaDAL _tabMatriculaDAL { get; }   
        ITabProfesorDAL _tabProfesorDAL { get; }   
        ITabRecetaDAL _tabRecetaDAL { get; }   


        bool Complete();    

    }
=======
	public interface IUnidadDeTrabajo : IDisposable
	{
		ITabCurso _tabCursoDAL { get; }
		ITabCursoImpartir _tabCursoImpartirDAL { get; }
		bool Complete();
	}
>>>>>>> Gustavo
}
