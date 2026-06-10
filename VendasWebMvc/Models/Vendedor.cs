using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " Obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = " Obrigatório")]
        [EmailAddress(ErrorMessage = "Insira um e-mail válido.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = " Obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = " Obrigatório")]
        [Range(100.0, 100000.0, ErrorMessage = " O {0} deve ser entre R$ {1} e R$ {2}.")]
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
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
