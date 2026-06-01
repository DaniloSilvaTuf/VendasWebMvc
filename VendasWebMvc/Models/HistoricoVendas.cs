using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class HistoricoVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public VendasStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public HistoricoVendas()
        {

        }
        public HistoricoVendas(int id, DateTime data, double valor, VendasStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
