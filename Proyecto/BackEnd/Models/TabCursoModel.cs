using Entities.Entities;

namespace BackEnd.Models
{
	public class TabCursoModel
	{
		public int IdCurso { get; set; }

		public string? Curso { get; set; }

		public DateOnly? FechaInicio { get; set; }

		public DateOnly? FechaFin { get; set; }

		public int? IdEstado { get; set; }

		public int? IdHorario { get; set; }

		public virtual TabEstado? IdEstadoNavigation { get; set; }

		public virtual TabHorario? IdHorarioNavigation { get; set; }

		public virtual ICollection<TabMatricula> TabMatriculas { get; set; } = new List<TabMatricula>();
	}
}
