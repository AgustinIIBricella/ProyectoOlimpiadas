using System.ComponentModel.DataAnnotations;

namespace ProyectoOlimpiadas.Data.Models
{
    public class DatosMedicos
    {
        public int id { get; set; }
        [StringLength(45)]
        public string grupo_sanguineo { get; set; }
        public bool alergias { get; set; }
        [StringLength(255)]
        public string? alergias_descripcion { get; set; }
        public bool medicamentos { get; set; }
        [StringLength(255)]
        public string? medicamentos_descripcion { get; set; }
        public bool vacunas { get; set; }
        [StringLength(255)]
        public string? vacunas_descripcion { get; set; }
    }
}
