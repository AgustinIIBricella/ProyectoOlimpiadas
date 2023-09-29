using System.ComponentModel.DataAnnotations;

namespace ProyectoOlimpiadas.Data.Models
{
    public class Area
    {
        public int id { get; set; }
        [StringLength(45)]
        public string nombre { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public List<Enfermero> Enfermeros { get; set; }
    }
}
