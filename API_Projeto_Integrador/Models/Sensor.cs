namespace API_Projeto_Integrador.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int Tipo { get; set; }

        public DateTime Data_Dado { get; set; }
    }
}
