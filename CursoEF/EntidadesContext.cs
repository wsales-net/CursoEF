using CursoEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
    }
}
