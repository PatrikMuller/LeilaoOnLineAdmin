using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.Database
{
    public class LeilaoOnlineContext : DbContext
    {
        ////Teste
        //public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }

        ////Banco pdv
        //public DbSet<Carrinho> Carrinhos { get; set; }
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
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=pdv;User Id=login_pdv;Password=123456;");
        }

        public void InicializaDB()
        {
            //
        }
    }
}
