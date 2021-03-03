using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoContext _context;

        public ProdutoController(ProdutoContext context)
        {
            _context = context;
        }

        [HttpPost("buscarProdutos")]
        public async Task<List<ProdutoModel>> Teste(Pagination model)
        {
            
            return await PagedModel<ProdutoModel>.CreateAsync(_context.Produtos.AsQueryable(), model.paginacao.paginaAtual, model.paginacao.itemsPorPagina);

        }

        // GET: api/Produto
        // [HttpGet("TodosProdutos")]
        // public async Task<ActionResult<IEnumerable<ProdutoModel>>> GetProdutos()
        //  {
        //     return await _context.Produtos.ToListAsync();
        //  }

        // GET: api/Produto/5
        [HttpGet("obterProduto/{id}")]
        public async Task<ActionResult<ProdutoModel>> GetProdutoModel(long id)
        {
            var produtoModel = await _context.Produtos.FindAsync(id);

            if (produtoModel == null)
            {
                return NotFound();
            }

            return produtoModel;
        }

        // POST: api/Produto
        [HttpPost("salvarProduto")]
        public async Task<ActionResult<ProdutoModel>> PostProdutoModel(ProdutoModel produtoModel)
        {
            _context.Produtos.Add(produtoModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdutoModel", new { id = produtoModel.Id }, produtoModel);
        }
        // DELETE: api/Produto/5
        [HttpDelete("excluirProduto/{id}")]
        public async Task<IActionResult> DeleteProdutoModel(long id)
        {
            var produtoModel = await _context.Produtos.FindAsync(id);
            if (produtoModel == null)
            {
                return NotFound();
            }

            _context.Produtos.Remove(produtoModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProdutoModelExists(long id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
