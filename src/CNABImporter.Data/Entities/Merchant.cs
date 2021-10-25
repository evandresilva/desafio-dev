using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CNABImporter.Data.Entities
{
    public class Merchant: BaseEntity
    {
        [MaxLength(19)]
        public string Name { get; set; }
        [MaxLength(14)]
        public string OwnerName { get; set; }
    }
}
