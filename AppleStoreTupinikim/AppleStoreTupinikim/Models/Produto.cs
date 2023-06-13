using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppleStoreTupinikim.Models
{
    public class Produto
    {
        [Display(Name ="ID")]
        [Column("#")]
        int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Nome do Produto")]
        string Nome { get; set; }
        [Display(Name = "Valor")]
        [Column("Valor ($)")]
        double Valor { get; set; }
        [Display(Name = "Estoque")]
        [Column("Estoque")]
        int Estoque { get; set; }
    }
}
