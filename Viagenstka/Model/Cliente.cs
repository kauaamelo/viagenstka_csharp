using System.ComponentModel.DataAnnotations.Schema;


namespace Viagenstka.Model
{

    [Table("cliente")]
    public class Cliente {

        [Column("id")]
        public int Id { get; set; }

         [Column("nomeCompleto")]
        public String nomeCompleto { get; set; }

        [Column("url")]
        public String Url { get; set; }

        [Column("cpf")]
        public String Cpf { get; set; }

        [Column("telefone")]
        public String Telefone { get; set; }

    }
    
}