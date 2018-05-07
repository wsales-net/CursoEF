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
            Produto p1 = context.Produto.Find(1);
            Produto p2 = context.Produto.Find(2);

            Usuario cliente = context.Usuario.Find(3);

            Venda venda = new Venda();
            venda.Cliente = cliente;
            venda.Produtos.Add(p1);
            venda.Produtos.Add(p2);

            context.Vendas.Add(venda);

            context.SaveChanges();

            context.Dispose();

            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
