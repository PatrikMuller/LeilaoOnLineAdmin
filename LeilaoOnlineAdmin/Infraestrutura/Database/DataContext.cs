using Microsoft.EntityFrameworkCore;
using Infraestrutura.Model;

namespace Infraestrutura.Database
{
    public class DataContext : DbContext
    {
        ////Teste
        //public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }

        //Banco pdv
        public DbSet<ModelModelo> Models { get; set; }
        //public DbSet<CarrinhoFormaPagamento> CarrinhoFormaPagamentos { get; set; }
        //public DbSet<CarrinhoItem> CarrinhoItems { get; set; }
        //public DbSet<CarrinhoPessoa> CarrinhoPessoas { get; set; }
        //public DbSet<CarrinhoPessoaTipo> CarrinhoPessoaTipos { get; set; }
        //public DbSet<Fabricante> Fabricantes { get; set; }
        //public DbSet<FormaPagamento> FormaPagamentos { get; set; }
        //public DbSet<FormaPagamentoParcelamento> FormaPagamentoParcelamentos { get; set; }
        //public DbSet<Item> Items { get; set; }
        //public DbSet<ParcelamentoStatus> ParcelamentoStatuses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=leilao_online;User Id=user_leilao_online;Password=detranR0;");
        }

        public void InicializaDB()
        {
            //
        }
    }
}
