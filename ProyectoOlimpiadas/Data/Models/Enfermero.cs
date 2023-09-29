using System.ComponentModel.DataAnnotations;

namespace ProyectoOlimpiadas.Data.Models
{
    public class Enfermero
    {
        public int id { get; set; }
        [StringLength(255)]
        public string nombre_completo { get; set; }
        [StringLength(45)]
        public string DNI { get; set; }
        [StringLength(255)]
        public string direccion { get; set; }
        [StringLength(45)]
        public string genero { get; set; }
        public DateTime fecha_de_nacimiento { get; set; }
        public int edad { get; set; }
        public Telefono telefono { get; set; }
        public List<Area> Area { get; set; }
    }
}
