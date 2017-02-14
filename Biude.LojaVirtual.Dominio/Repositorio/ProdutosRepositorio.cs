using Biude.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biude.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EFDBContext _context = new EFDBContext();
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
