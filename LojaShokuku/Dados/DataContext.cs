using LojaShokuku.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LojaShokuku.Dados
{
    public class DataContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}