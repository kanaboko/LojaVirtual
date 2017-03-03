using Biude.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biude.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        // GET: Vitrine
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 1;
        // GET: Produtos
        public ActionResult Index(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.OrderBy(p=>p.Nome).Skip((pagina - 1) * ProdutosPorPagina).Take(ProdutosPorPagina);
            return View(produtos);
        }
    }
}