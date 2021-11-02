using System;
using System.Collections.Generic;
using System.Text;

namespace CNABImporter.Models.Service.Dtos
{
    public class TransactionImportedRowDto
    {
        public int TransactionTypeId { get; set; }
        public DateTime TransactedAt { get; set; }
        public decimal Amount { get; set; }
        public string CPF { get; set; }
        public string CardNumber { get; set; }
        public string StoreName { get; set; }
        public string StoreOwnerName { get; set; }
    }
}
