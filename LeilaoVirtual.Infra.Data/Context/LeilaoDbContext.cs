using LeilaoVirtual.Domain.Features.Auctions;
using LeilaoVirtual.Domain.Features.Moves;
using LeilaoVirtual.Domain.Features.Persons;
using LeilaoVirtual.Domain.Features.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeilaoVirtual.Infra.Data.Context
{
    public class LeilaoDbContext : DbContext
    {

        public LeilaoDbContext(DbContextOptions<LeilaoDbContext> options) : base(options) { }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
