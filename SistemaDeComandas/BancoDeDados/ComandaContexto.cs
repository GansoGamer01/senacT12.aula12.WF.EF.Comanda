using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeComandas.BancoDeDados
{
    public class ComandaContexto : DbContext
    {
        // criar as variaveis que representam as tabelas \\
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<CardapioItem> cardapioItems { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaItem> ComandaItems { get; set; }
        public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
        public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=comanda.db");
            base.OnConfiguring(optionsBuilder);
        }

        // para configurar os relacionamentos das tabelas \\
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //acesse a entidade cardapioItem para determinar a nomenclatura \\
            modelBuilder.Entity<Comanda>()
                .HasComment("cadastro de itens do cardapio");

            // uma comanda possui muitos comandaItens \\
            // e sua chave estrangeira é comandaId \\
            modelBuilder.Entity<Comanda>()
                .HasMany<ComandaItem>()
                .WithOne(ci => ci.Comanda)
                .HasForeignKey(f => f.ComandaId);

            // o item da comanda possui um item do Cardapio \\
            // e sua chave estrangeira é CardapioItemId \\
            modelBuilder.Entity<ComandaItem>()
                .HasOne(ci => ci.CardapioItem)
                .WithMany()
                .HasForeignKey(ASCIIEncoding => ASCIIEncoding.CardapioItemId);

            // pedido cozinha com pedido cozinha item \\
            modelBuilder.Entity<PedidoCozinha>()
                .HasMany<PedidoCozinhaItem>()
                .WithOne(pci => pci.PedidoCozinha)
                .HasForeignKey(pci => pci.PedidoCozinhaId);
            
            // pedido cozinha item possui um comanda id \\
            // e sua chave estrangeira é comanda id \\
            modelBuilder.Entity<PedidoCozinhaItem>()
                .HasOne(pci => pci.ComandaItem)
                .WithMany()
                .HasForeignKey(pci => pci.ComandaItemId);

            base.OnModelCreating(modelBuilder);
        }
    }
}