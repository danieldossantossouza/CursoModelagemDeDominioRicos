using Microsoft.EntityFrameworkCore;
using ModelagemDominioRiscocurso.Catalogo.Domain;
using ModelagemDominioRiscoCurso.Core.Data;

namespace ModelagemDominioRicos.Catalogo.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly CatalogoContext _context;
        public ProdutoRepository(CatalogoContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
           return await _context.Produtos.AsNoTracking().ToListAsync();
        }

        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _context.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<IEnumerable<Produto>> ObterPorcategoria(int codigo)
        {
            return await _context.Produtos.AsNoTracking().Include(p => p.Categoria).Where(c => c.Categoria.Codigo == codigo).ToListAsync();

        }
        public async Task<IEnumerable<Categoria>> ObterCategorias()
        {
            return await _context.Categorias.AsNoTracking().ToListAsync(); 
        }

        public void Adicionar(Produto produto)
        {
            _context.Add(produto);
        }

        public void Adicionar(Categoria categoria)
        {
            _context.Add(categoria);
        }

        public void Atualizar(Produto produto)
        {
           _context.Update(produto);    
        }

        public void Atualizar(Categoria categoria)
        {
            _context.Update(categoria);
        }


        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
