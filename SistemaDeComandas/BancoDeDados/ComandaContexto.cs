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
    }
}
