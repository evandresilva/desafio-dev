using CNABImporter.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CNABImporter.Data.Configurations
{
    public class TransactionTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {
            builder.HasData(new TransactionType
            {
                Id = 1,
                Description = "Débito",
                TransactionNatureId = 1,
            },
            new TransactionType
            {
                Id = 2,
                Description = "Boleto",
                TransactionNatureId = 2
            },
             new TransactionType
             {
                 Id = 3,
                 Description = "Financiamento",
                 TransactionNatureId = 2
             },
              new TransactionType
              {
                  Id = 4,
                  Description = "Crédito",
                  TransactionNatureId = 1
              },
               new TransactionType
               {
                   Id = 5,
                   Description = "Recebimento Empréstimo",
                   TransactionNatureId = 1
               },
                new TransactionType
                {
                    Id = 6,
                    Description = "Vendas",
                    TransactionNatureId = 1
                },
                 new TransactionType
                 {
                     Id = 7,
                     Description = "Recebimento TED",
                     TransactionNatureId = 1
                 },
                  new TransactionType
                  {
                      Id = 8,
                      Description = "Recebimento DOC",
                      TransactionNatureId = 1
                  },
                   new TransactionType
                   {
                       Id = 9,
                       Description = "Aluguel",
                       TransactionNatureId = 2
                   }
          );
        }
    }
}
