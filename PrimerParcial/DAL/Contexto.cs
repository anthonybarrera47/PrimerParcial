using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<String> hola { get; set; }
        public Contexto() : base ("ConStr")
        {

        }
    }
}
