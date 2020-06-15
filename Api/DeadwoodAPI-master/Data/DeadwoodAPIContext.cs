using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DeadwoodAPI.Models
{
    public class DeadwoodAPIContext : DbContext
    {
        public DeadwoodAPIContext (DbContextOptions<DeadwoodAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DeadwoodAPI.Models.Survey> Survey { get; set; }
    }
}
