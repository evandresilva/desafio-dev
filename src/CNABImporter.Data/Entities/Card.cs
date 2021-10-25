using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CNABImporter.Data.Entities
{
    public class Card : BaseEntity
    {
        [MaxLength(12)]
        public string CardNumber { get; set; }
    }
}
