using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CNABImporter.Data.Entities
{
    public class Client: BaseEntity
    {
        [MaxLength(11)]
        public string CPF { get; set; }
    }
}
