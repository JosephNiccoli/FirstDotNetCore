using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Models;  // Enables public DbSet<Movie> Movie

namespace HelloWorld.Models
{
    public class HelloWorldContext : DbContext
    {
        public HelloWorldContext (DbContextOptions<HelloWorldContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
