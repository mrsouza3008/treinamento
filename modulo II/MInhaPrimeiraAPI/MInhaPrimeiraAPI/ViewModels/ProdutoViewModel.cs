using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MInhaPrimeiraAPI.ViewModels
{
    public class ProdutoAdicionarViewModel
    {

        [Required]  // torna o campo obrigatorio
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }
        [Required]
        [Range(1, 99999, ErrorMessage = "O valor deve estar entre {1} e {2}")]    // coloca uma faixa de valores aceitos
        public decimal Valor { get; set; }
    }

    public class ProdutoEditarViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]  // torna o campo obrigatorio
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }
        [Required]
        [Range(1, 99999, ErrorMessage = "O valor deve estar entre {1} e {2}")]    // coloca uma faixa de valores aceitos
        public decimal Valor { get; set; }
    }

}
