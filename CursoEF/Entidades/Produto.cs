using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Entidades
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        //Propriedade de relacionamento, usa-se virtual.
        public virtual Categoria Categoria { get; set; }

        public int? CategoriaId { get; set; }
    }
}
