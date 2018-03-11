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

            Categoria categoria = context.Categoria.Find(1);
            foreach (var produto in categoria.Produtos)
            {
                Console.WriteLine(produto.Nome);
            }

            context.Dispose();

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}
