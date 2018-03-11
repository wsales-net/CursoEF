using CursoEF.DAO;
using CursoEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext context = new EntidadesContext();

            var busca = from c in context.Categoria select new ProdutosPorCategoria(){ Categoria = c, NumeroProdutos = c.Produtos.Count };

            IList<ProdutosPorCategoria> resultado = busca.ToList();
            foreach (var r in resultado)
            {
                Console.WriteLine(r.Categoria.Nome + " - " + r.NumeroProdutos);
            }
            context.Dispose();

            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
