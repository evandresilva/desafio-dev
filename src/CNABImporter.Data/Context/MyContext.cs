using Microsoft.EntityFrameworkCore;
using CNABImporter.Data.Entities;
using System.Collections.Generic;
using System;
using System.Text;
using CNABImporter.Data.Configurations;

namespace CNABImporter.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Client> Clients{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Card> Cards{ get; set; }
        public DbSet<TransactionType> TransactionTypes{ get; set; }
        public DbSet<TransactionNature> TransactionNatures{ get; set; }
        public DbSet<Merchant> Merchants{ get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionType>(new TransactionTypeConfiguration().Configure);
            modelBuilder.Entity<TransactionNature>(new TransactionNatureConfiguration().Configure);
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
