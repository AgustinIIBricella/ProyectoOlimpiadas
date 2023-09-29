using System.ComponentModel.DataAnnotations;

namespace ProyectoOlimpiadas.Data.Models
{
    public class Telefono
    {
        public int id { get; set; }
        [StringLength(255)]

        public string? fijo { get; set; }
        [StringLength(255)]

        public string? celular { get; set;}
        [StringLength(255)]

        public string? otro { get; set;} 
    }
}
