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
        public DbSet<Transaction> TransactionEntities { get; set; }
        public DbSet<Client> ClientEntities{ get; set; }
        public DbSet<Card> CardEntities{ get; set; }
        public DbSet<TransactionType> TransactionTypeEntities{ get; set; }
        public DbSet<TransactionNature> TransactionNatureEntities{ get; set; }
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
