using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CNABImporter.Data.Entities
{
    public class Transaction : BaseEntity
    {
        [Column(TypeName = "money")]
        [MaxLength(10)]
        public decimal Amount { get; set; }
        public Guid CardId { get; set; }
        public Guid ClientId { get; set; }
        public DateTime TransactedAt { get; set; }
        public Guid MerchantId { get; set; }
        public int TransactionTypeId { get; set; }

        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }
        [ForeignKey("TransactionTypeId")]
        public TransactionType TransactionType { get; set; }
        [ForeignKey("CardId")]
        public Card Card { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
