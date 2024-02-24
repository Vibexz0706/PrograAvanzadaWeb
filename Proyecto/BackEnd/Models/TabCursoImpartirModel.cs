using Entities.Entities;

namespace BackEnd.Models
{
	public class TabCursoImpartirModel
	{
		public int IdCursoImpartir { get; set; }

		public int? IdCurso { get; set; }

		public int? IdProfesor { get; set; }

		public virtual TabProfesor? IdProfesorNavigation { get; set; }
	}
}
