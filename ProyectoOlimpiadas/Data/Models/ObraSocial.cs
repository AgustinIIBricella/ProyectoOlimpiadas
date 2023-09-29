using System.ComponentModel.DataAnnotations;

namespace ProyectoOlimpiadas.Data.Models
{
    public class ObraSocial
    {
        public int id { get; set; }
        [StringLength(45)]
        public string numerodeafiliado { get; set; }
        [StringLength(45)]
        public string nombre { get; set; }
    }
}
