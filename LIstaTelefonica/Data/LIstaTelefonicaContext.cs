using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LIstaTelefonica.Models;

namespace LIstaTelefonica.Data
{
    public class LIstaTelefonicaContext : DbContext
    {
        public LIstaTelefonicaContext (DbContextOptions<LIstaTelefonicaContext> options)
            : base(options)
        {
        }

        public DbSet<LIstaTelefonica.Models.ListaTelefonica> ListaTelefonica { get; set; } = default!;
    }
}
