using DessaVezEuNaoEsquecoAPI.Models; // Importa o namespace onde o modelo Atividade está definido.
using Microsoft.EntityFrameworkCore;  // Importa o namespace necessário para usar o Entity Framework Core.

namespace DessaVezEuNaoEsquecoAPI.Data;

public class DessaVezEuNaoEsquecoContext : DbContext
{
    // Construtor que aceita opções de configuração para o contexto e passa essas opções para o construtor base da classe DbContext.
    public DessaVezEuNaoEsquecoContext(DbContextOptions<DessaVezEuNaoEsquecoContext> options)
        : base(options)
    {
    }

    // Propriedade DbSet que representa a coleção de Atividades na base de dados.
    public DbSet<Atividade> Atividades { get; set; }
}
