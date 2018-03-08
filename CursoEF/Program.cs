using CursoEF.DAO;
using CursoEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext context = new EntidadesContext();
            Usuario usuario = new Usuario();
            usuario.Nome = "Guilherme";
            usuario.Senha = "456";

            context.Usuario.Add(usuario);
            context.SaveChanges();

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}
