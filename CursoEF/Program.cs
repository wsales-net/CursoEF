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

            //trazer os produtos da categoria específica
            var busca = from c in context.Categoria.Include("Produtos") select c;

            IList<Categoria> resultado = busca.ToList();

            Console.WriteLine(busca.ToString());

            foreach (var c in resultado)
            {
                Console.WriteLine(c.Nome + " - " + c.Produtos.Count);
            }
            context.Dispose();

            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
