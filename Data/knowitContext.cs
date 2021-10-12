using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using knowit.Model;

namespace knowit.Data
{
    public class knowitContext : DbContext
    {
        public knowitContext (DbContextOptions<knowitContext> options)
            : base(options)
        {
        }

        public DbSet<knowit.Model.Bookmangement> Bookmangement { get; set; }
    }
}
