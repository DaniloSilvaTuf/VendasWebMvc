using System.ComponentModel.DataAnnotations;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class HistoricoVendas
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
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
