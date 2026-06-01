using VendasWebMvc.Models;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Data
{
    public class SeedingService
    {
        private VendasWebMvcContext _context;

        public SeedingService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.HistoricoVendas.Any())
            {
                return; // DB já foi populado
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Moda");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor s1 = new Vendedor(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor s2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor s3 = new Vendedor(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor s4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedor s5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedor s6 = new Vendedor(6, "Alex Pink", "alex@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            HistoricoVendas v1 = new HistoricoVendas(1, new DateTime(2018, 09, 25), 11000.0, VendasStatus.Faturado, s1);
            HistoricoVendas v2 = new HistoricoVendas(2, new DateTime(2018, 09, 4), 7000.0, VendasStatus.Faturado, s5);
            HistoricoVendas v3 = new HistoricoVendas(3, new DateTime(2018, 09, 13), 4000.0, VendasStatus.Cancelado, s4);
            HistoricoVendas v4 = new HistoricoVendas(4, new DateTime(2018, 09, 1), 8000.0, VendasStatus.Faturado, s1);
            HistoricoVendas v5 = new HistoricoVendas(5, new DateTime(2018, 09, 21), 3000.0, VendasStatus.Faturado, s3);
            HistoricoVendas v6 = new HistoricoVendas(6, new DateTime(2018, 09, 15), 2000.0, VendasStatus.Faturado, s1);
            HistoricoVendas v7 = new HistoricoVendas(7, new DateTime(2018, 09, 28), 13000.0, VendasStatus.Faturado, s2);
            HistoricoVendas v8 = new HistoricoVendas(8, new DateTime(2018, 09, 11), 4000.0, VendasStatus.Faturado, s4);
            HistoricoVendas v9 = new HistoricoVendas(9, new DateTime(2018, 09, 14), 11000.0, VendasStatus.Pendente, s6);
            HistoricoVendas v10 = new HistoricoVendas(10, new DateTime(2018, 09, 7), 9000.0, VendasStatus.Faturado, s6);
            HistoricoVendas v11 = new HistoricoVendas(11, new DateTime(2018, 09, 13), 6000.0, VendasStatus.Faturado, s2);
            HistoricoVendas v12 = new HistoricoVendas(12, new DateTime(2018, 09, 25), 7000.0, VendasStatus.Pendente, s3);
            HistoricoVendas v13 = new HistoricoVendas(13, new DateTime(2018, 09, 29), 10000.0, VendasStatus.Faturado, s4);
            HistoricoVendas v14 = new HistoricoVendas(14, new DateTime(2018, 09, 4), 3000.0, VendasStatus.Faturado, s5);
            HistoricoVendas v15 = new HistoricoVendas(15, new DateTime(2018, 09, 12), 4000.0, VendasStatus.Faturado, s1);
            HistoricoVendas v16 = new HistoricoVendas(16, new DateTime(2018, 10, 5), 2000.0, VendasStatus.Faturado, s4);
            HistoricoVendas v17 = new HistoricoVendas(17, new DateTime(2018, 10, 1), 12000.0, VendasStatus.Faturado, s1);
            HistoricoVendas v18 = new HistoricoVendas(18, new DateTime(2018, 10, 24), 6000.0, VendasStatus.Faturado, s3);
            HistoricoVendas v19 = new HistoricoVendas(19, new DateTime(2018, 10, 22), 8000.0, VendasStatus.Faturado, s5);
            HistoricoVendas v20 = new HistoricoVendas(20, new DateTime(2018, 10, 15), 8000.0, VendasStatus.Faturado, s6);
            HistoricoVendas v21 = new HistoricoVendas(21, new DateTime(2018, 10, 17), 9000.0, VendasStatus.Faturado, s2);
            HistoricoVendas v22 = new HistoricoVendas(22, new DateTime(2018, 10, 24), 4000.0, VendasStatus.Faturado, s4);
            HistoricoVendas v23 = new HistoricoVendas(23, new DateTime(2018, 10, 19), 11000.0, VendasStatus.Cancelado, s2);
            HistoricoVendas v24 = new HistoricoVendas(24, new DateTime(2018, 10, 12), 8000.0, VendasStatus.Faturado, s5);
            HistoricoVendas v25 = new HistoricoVendas(25, new DateTime(2018, 10, 31), 7000.0, VendasStatus.Faturado, s3);
            HistoricoVendas v26 = new HistoricoVendas(26, new DateTime(2018, 10, 6), 5000.0, VendasStatus.Faturado, s4);
            HistoricoVendas v27 = new HistoricoVendas(27, new DateTime(2018, 10, 13), 9000.0, VendasStatus.Pendente, s1);
            HistoricoVendas v28 = new HistoricoVendas(28, new DateTime(2018, 10, 7), 4000.0, VendasStatus.Faturado, s3);
            HistoricoVendas v29 = new HistoricoVendas(29, new DateTime(2018, 10, 23), 12000.0, VendasStatus.Faturado, s5);
            HistoricoVendas v30 = new HistoricoVendas(30, new DateTime(2018, 10, 12), 5000.0, VendasStatus.Faturado, s2);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6);
            _context.HistoricoVendas.AddRange(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10,
                                          v11, v12, v13, v14, v15, v16, v17, v18, v19, v20,
                                          v21, v22, v23, v24, v25, v26, v27, v28, v29, v30);

            _context.SaveChanges();
        }
    }
}
