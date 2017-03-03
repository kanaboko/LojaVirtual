using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Biude.LojaVirtual.Teste
{
    [TestClass]
    public class BiudeTest
    {
        [TestMethod]
        public void Take()
        {
            int[] pagina = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var resultado = from num in pagina.Take(5) select num;
            int[] paginaTeste = { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEqual(resultado.ToArray(), paginaTeste);
        }

        [TestMethod]
        public void Skip()
        {
            int[] pagina = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var resultado = from num in pagina.Skip(3).Take(5) select num;
            int[] paginaTeste = { 4, 5, 6, 7, 8 };
            CollectionAssert.AreEqual(resultado.ToArray(), paginaTeste);
        }
    }
}
