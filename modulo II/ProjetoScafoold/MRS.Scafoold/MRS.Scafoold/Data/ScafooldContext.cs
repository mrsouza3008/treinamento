using Microsoft.EntityFrameworkCore;
using MRS.Scafoold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MRS.Scafoold.Data
{
    public class ScafooldContext : DbContext
    {
        public ScafooldContext(DbContextOptions<ScafooldContext> options) 
            : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
