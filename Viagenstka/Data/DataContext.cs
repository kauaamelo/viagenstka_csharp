using Microsoft.EntityFrameworkCore;
using Viagenstka.Model;

namespace Viagenstka.Data

{

    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<Cliente> Viagenstka { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, nomeCompleto = "Thamires Almeida", Url = "https://fv5-2.failiem.lv/down.php?i=9zh6bmhrnj&view", Cpf = "122.122.133-33", Telefone = "(21)99797-4565" },
                new Cliente { Id = 2, nomeCompleto = "Ana Santos", Url = "https://fv5-2.failiem.lv/down.php?i=3g2ng3ugd2&view", Cpf = "178.178.177-78", Telefone = "(87)3184-2819" },
                new Cliente { Id = 3, nomeCompleto = "Angela Rocha", Url = "https://fv5-2.failiem.lv/down.php?i=dv3vdcf54z&view", Cpf = "769.290.670-08", Telefone = "(21)92555-2381" },
                new Cliente { Id = 4, nomeCompleto = "José Carlos", Url = "https://fv5-2.failiem.lv/down.php?i=eqxha3jn88&view", Cpf = "791.555.800-50", Telefone = "(18)93571-6471" },
	            new Cliente { Id = 5, nomeCompleto = "Vitor Alves", Url = "https://fv5-2.failiem.lv/down.php?i=8s9g72yxj9&view", Cpf = "532.284.780-41", Telefone = "(13)92741-3363" }
            );
        }

    }
}