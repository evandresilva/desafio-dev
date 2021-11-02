using System;
using System.Collections.Generic;
using System.Text;

namespace CNABImporter.Service.Models.Dtos
{
    public class TransactionDto
    {
       public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public Guid CardId { get; set; }
        public Guid ClientId { get; set; }
        public DateTime TransactedAt { get; set; }
        public Guid MerchantId { get; set; }
        public Guid TransactionTypeId { get; set; }
        public string Merchant { get; set; }
        public string TransactionType { get; set; }
        public string Card { get; set; }
        public string Client { get; set; }
    }
}
