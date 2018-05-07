using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Entidades
{
    public class PessoaJuridica : Usuario
    {
        public string CNPJ { get; set; }
    }
}
