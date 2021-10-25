using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNABImporter.Data.Entities
{
    public class TransactionType: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public new int Id { get; set; }
        [MaxLength(16)]
        public string Description { get; set; }
        public int TransactionNatureId { get; set; }

        [ForeignKey("TransactionNatureId")]
        public TransactionNature TransactionNature { get; set; }
    }
}
