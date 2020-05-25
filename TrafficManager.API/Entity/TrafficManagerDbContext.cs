using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrafficManager.API.Models;

namespace TrafficManager.Infrastructure
{
    class TrafficManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public TrafficManagerDbContext(DbContextOptions<TrafficManagerDbContext> options)
            : base(options)
        {
        }

    }
}
