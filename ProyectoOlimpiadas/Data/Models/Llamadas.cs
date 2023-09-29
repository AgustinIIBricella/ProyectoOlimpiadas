namespace ProyectoOlimpiadas.Data.Models
{
    public class Llamadas
    {
        public int id { get; set; }
        public bool gravedad { get; set; }
        public bool origen { get; set; }
        public DateTime tiempo_de_llamada { get; set; }
        public DateTime? tiempo_de_atencion { get; set; }
        public DateTime fecha_y_hora { get; set; }

    }
}
