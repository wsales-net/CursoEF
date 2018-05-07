using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Entidades
{
    public class Venda
    {
        public int Id { get; set; }
        public virtual Usuario Cliente { get; set; }

        public int ClienteId { get; set; }

        public virtual IList<Produto> Produtos { get; set; }

        public Venda()
        {
            this.Produtos = new List<Produto>();
        }
    }
}
