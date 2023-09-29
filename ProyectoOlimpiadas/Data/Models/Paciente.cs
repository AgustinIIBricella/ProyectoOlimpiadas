using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoOlimpiadas.Data.Models
{
    public class Paciente
    {
        public int id {  get; set; }
        [StringLength(255)]
        public string nombre_completo { get; set; }
        [StringLength(45)]
        public string DNI { get; set; }
        [StringLength(45)]
        public string genero { get; set; }
        [StringLength(45)]
        public string direccion { get; set; }
        public DateTime fecha_de_naciemiento { get; set; }
        public int edad { get; set; }
        [StringLength(255)]
        public string email { get; set; }
        public int AreaId { get; set; }
        [ForeignKey("AreaId")]
        public Area Area { get; set; }
        public int TelefonoId { get; set; }
        [ForeignKey("TelefonoId")]
        public Telefono Telefono { get; set; }
        public int DatosMedicosId { get; set; }
        [ForeignKey("DatosMedicosId")]
        public DatosMedicos DatosMedicos { get; set; }
        public int ObraSocialId { get; set; }
        [ForeignKey("ObraSocialId")]
        public ObraSocial ObraSocial { get; set; }
    }
}
