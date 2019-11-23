using System.ComponentModel.DataAnnotations;

namespace MInhaPrimeiraAPI.Models
{
    public class Produto
    {
       [Key]
       public int Id { get; set; }

       public string Descricao { get; set; }

       public decimal Valor { get; set; }
    }
}
