using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNotes.Data;

namespace DNotes.Context
{
    public class DNotesDbContext : DbContext
    {
        public DNotesDbContext(DbContextOptions<DNotesDbContext> options) : base(options)
        {

        }

        public DbSet<Image> Images { get; set; }
    }
}
