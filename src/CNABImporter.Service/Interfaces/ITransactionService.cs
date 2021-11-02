using CNABImporter.Models.Service.Dtos;
using CNABImporter.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CNABImporter.Service.Interfaces
{
    public interface ITransactionService
    {
        public TransactionImportedRowDto ParseRowFromFile(string row);
        public AppResult AddTransaction(string row);
    }
}
