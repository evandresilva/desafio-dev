using CNABImporter.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CNABImporter.Data.Configurations
{
    public class TransactionNatureConfiguration
    {
        public void Configure(EntityTypeBuilder<TransactionNature> builder)
        {
            builder.HasData(new TransactionNature
            {
                Id = 1,
                Description = "Entrada",
            },
            new TransactionNature
            {
                Id = 2,
                Description = "Saída"
            }
          );
        }
    }
}
