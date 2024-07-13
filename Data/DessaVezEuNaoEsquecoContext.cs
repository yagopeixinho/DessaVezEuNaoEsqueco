using DessaVezEuNaoEsquecoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DessaVezEuNaoEsquecoAPI.Data;

public class DessaVezEuNaoEsquecoContext : DbContext
{
    public DessaVezEuNaoEsquecoContext(DbContextOptions<DessaVezEuNaoEsquecoContext> options)
        : base(options)
    {
    }

    public DbSet<Atividade> Atividades { get; set; }
}