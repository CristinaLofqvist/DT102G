using System;
using DT102G_Moment_3_2.Models;
using Microsoft.EntityFrameworkCore;

namespace DT102G_Moment_3_2.Data
{
    public class CDLibaryContext : DbContext
    {
        public CDLibaryContext(DbContextOptions<CDLibaryContext> options) : base(options)
        {
        }
        public DbSet<CD> CDs { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}
