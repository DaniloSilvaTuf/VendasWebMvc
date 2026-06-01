using System.Linq;
namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<HistoricoVendas> Vendas { get; set; } = new List<HistoricoVendas>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(HistoricoVendas hv)
        {
            Vendas.Add(hv);
        }

        public void RemoveVendas(HistoricoVendas hv)
        {
            Vendas.Remove(hv);
        }

        public double VendasTotais(DateTime inicial, DateTime final)
        {
            return Vendas.Where(hv => hv.Data >= inicial && hv.Data <= final).Sum(hv => hv.Valor);
        }
    }
}
