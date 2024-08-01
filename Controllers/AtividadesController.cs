using DessaVezEuNaoEsquecoAPI.Data;
using DessaVezEuNaoEsquecoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DessaVezEuNaoEsquecoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AtividadesController : ControllerBase
{
    private readonly DessaVezEuNaoEsquecoContext _context;

    public AtividadesController(DessaVezEuNaoEsquecoContext context)
    {
        _context = context;
    }
    
    // GET: api/atividades
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Atividade>>> GetAtividades()
    {
        // Retorna todas as atividades do banco de dados de forma assíncrona.
        return await _context.Atividades.ToListAsync();
    }

    // GET: api/atividades/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Atividade>> GetAtividade(int id)
    {
        // Procura uma atividade pelo ID fornecido.
        var atividade = await _context.Atividades.FindAsync(id);

        // Verifica se a atividade foi encontrada. Se não, retorna NotFound.
        if (atividade == null)
        {
            return NotFound();
        }

        return atividade;
    }
    
    // POST: api/atividades
    [HttpPost]
    public async Task<ActionResult<Atividade>> PostAtividade(Atividade atividade)
    {
        // Adiciona a nova atividade ao contexto.
        _context.Atividades.Add(atividade);

        // Salva as mudanças no banco de dados de forma assíncrona.
        await _context.SaveChangesAsync();

        // Retorna um status HTTP 201 Created, com a URL do novo recurso criado.
        return CreatedAtAction(nameof(GetAtividades), new { id = atividade.Id }, atividade); 
    }

    // PUT: api/atividades/1
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAtividade(int id, Atividade atividade)
    {
        // Verifica se o ID da URL é diferente do ID da atividade.
        if (id != atividade.Id)
        {
            // Retorna BadRequest (400) se os IDs não coincidirem.
            return BadRequest();
        }

        // Atualiza o estado da atividade no contexto para Modified.
        _context.Atividades.Update(atividade);

        try
        {
            // Salva as mudanças no banco de dados de forma assíncrona.
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            // Se ocorrer uma exceção de concorrência, re-lança a exceção.
            throw;
        }

        // Retorna Ok (200) com a atividade atualizada.
        return Ok(atividade);
    }

    // DELETE: api/atividades/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAtividade(int id)
    {
        // Tenta encontrar a atividade com o ID fornecido no banco de dados.
        var atividade = await _context.Atividades.FindAsync(id);

        // Verifica se a atividade não foi encontrada. Se não, retorna NotFound.
        if (atividade == null)
        {
            return NotFound();
        }

        // Remove a atividade do contexto.
        _context.Atividades.Remove(atividade);

        // Salva as mudanças no banco de dados de forma assíncrona.
        await _context.SaveChangesAsync();

        // Retorna NoContent (204) para indicar sucesso sem conteúdo no corpo da resposta.
        return NoContent();
    }
}
