namespace DessaVezEuNaoEsquecoAPI.Models;

using System.ComponentModel.DataAnnotations;

public class Atividade
{
    // Propriedade que representa o identificador único da atividade
    public int Id { get; set; }
    
    // Propriedade que representa o nome da atividade.
    // Atributo StringLength define um tamanho máximo de 50 caracteres.
    // Atributo Required indica que o campo é obrigatório.
    [StringLength(50)]
    [Required]
    public required string Nome { get; set; } // Nome da nossa atividade que não deve ser esquecida.
    
    // Propriedade que representa a data em que a atividade deve ser realizada
    public DateTime Data { get; set; } // Data de realizar a atividade.
}
