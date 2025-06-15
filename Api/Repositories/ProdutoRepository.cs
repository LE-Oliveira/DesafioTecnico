using Api.Models;
using Api.Data;
using Microsoft.EntityFrameworkCore;

public class ProdutoRepository{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context){
        _context = context;
    }

    public async Task<Produto?> GetByIdAsync(int id) =>
        await _context.Produtos.FindAsync(id);

    public async Task<List<Produto>> GetAllAsync() =>
        await _context.Produtos.ToListAsync();

    public async Task AddAsync(Produto produto){
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Produto produto){
        _context.Produtos.Update(produto);
        await _context.SaveChangesAsync();
    }
}
