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
            EntidadesContext contexto = new EntidadesContext();
            contexto.Database.CreateIfNotExists();

            Usuario usuario = new Usuario()
            {
                Nome = "Well",
                Senha = "123"
            };
            contexto.Usuario.Add(usuario);

            contexto.SaveChanges();

            contexto.Dispose();
        }
    }
}
