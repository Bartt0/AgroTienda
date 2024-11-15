using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agroTienda.Models.Producto;

namespace agroTienda.Data
{
    public class MyDbContext : Dbcontext
    {
        public DbSet<Producto> Producto { get; set; }
        
    }
}