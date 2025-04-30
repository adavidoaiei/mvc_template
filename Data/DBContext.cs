using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory> Inventory { get; set; } = default!;

        public DbSet<Persons> Persons { get; set; } = default!;

        public DbSet<Product> Products { get; set; } = default!;

        public DbSet<Tourism> Tourism { get; set; } = default!;
    }
