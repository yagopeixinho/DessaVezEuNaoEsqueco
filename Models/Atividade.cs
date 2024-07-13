namespace DessaVezEuNaoEsquecoAPI.Models;
using System.ComponentModel.DataAnnotations;

public class Atividade
{
    public int Id { get; set; }
    
    [StringLength(50)]
    [Required]
    public required string Nome { get; set; } // Nome da nossa atividade que não deve ser esquecida.
    
    public DateTime Data { get; set; } // Data de realizar a atividade.
}