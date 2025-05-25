namespace MauiAppEventos.Models
{
   public class Evento
    {
        public required string Nome {  get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public int Participantes { get; set; }
        public required string Local { get; set; }
        public required double Custo { get; set; }
    }
}
