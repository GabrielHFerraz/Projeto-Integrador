namespace API_Projeto_Integrador.Models
{
    public class DadoSensor
    {
        public int Id { get; set; }
        public int Id_Sensor { get; set; }
        public float valor { get; set; }
        public bool status { get; set; }
        public DateTime data_alteracao { get; set; }
    }
}
