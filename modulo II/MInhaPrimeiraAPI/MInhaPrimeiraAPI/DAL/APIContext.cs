using Microsoft.EntityFrameworkCore;
using MInhaPrimeiraAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MInhaPrimeiraAPI.DAL
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) 
            :base(options)
        {

        }
        
        public DbSet<Produto> Produtos { get; set; }  
    }
}
