namespace API_Projeto_Integrador.Models
{
    public class DadoSensor
    {
        public int Id { get; set; }
        public int id_sensor { get; set; }
        public float valor { get; set; }
        public bool estado { get; set; }
        public DateTime data_dado { get; set; }
    }
}
