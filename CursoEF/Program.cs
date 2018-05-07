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
            PessoaFisica well = new PessoaFisica();
            well.Nome = "Well";
            well.CPF = "123";

            PessoaJuridica alura = new PessoaJuridica();
            alura.Nome = "Alura";
            alura.CNPJ = "2345";

            context.Usuario.Add(well);
            context.Usuario.Add(alura);

            context.SaveChanges();

            context.Dispose();

            Console.WriteLine("\nPressione ENTER para sair...");
            Console.Read();
        }
    }
}
