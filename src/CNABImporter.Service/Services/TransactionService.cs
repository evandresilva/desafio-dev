using CNABImporter.Data.Context;
using CNABImporter.Data.Entities;
using CNABImporter.Models.Service.Dtos;
using CNABImporter.Service.Interfaces;
using CNABImporter.Service.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CNABImporter.Service.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly MyContext _db;
        public TransactionService(MyContext db)
        {
            _db = db;
        }
        public AppResult AddTransaction(string row)
        {
            var result = new AppResult();
            try
            {
                var dto = ParseRowFromFile(row);
                if (dto == null)
                    return result.Bad("Erro ao converter registro");

                if (!_db.TransactionTypes.Any(x => x.Id == dto.TransactionTypeId))

                    return result.Bad("Tipo de transação inexistente");

                var client = _db.Clients.FirstOrDefault(x => x.CPF == dto.CPF);
                if (client == null)
                {
                    client = new Client
                    {
                        Id = Guid.NewGuid(),
                        CPF = dto.CPF,
                    };
                    _db.Clients.Add(client);
                }
                var merchant = _db.Merchants.FirstOrDefault(x => x.Name.ToLower() == dto.StoreName.ToLower()
                                                             && x.OwnerName.ToLower() == dto.StoreOwnerName.ToLower());
                if (merchant == null)
                {
                    merchant = new Merchant
                    {
                        Id = Guid.NewGuid(),
                        Name = dto.StoreName,
                        OwnerName = dto.StoreName,
                    };
                    _db.Merchants.Add(merchant);
                }
                var card = _db.Cards.FirstOrDefault(x => x.CardNumber == dto.CardNumber);
                if (card == null)
                {
                    card = new Card
                    {
                        Id = Guid.NewGuid(),
                        CardNumber = dto.CardNumber
                    };
                    _db.Cards.Add(card);
                }
                _db.Transactions.Add(new Data.Entities.Transaction
                {
                    Id = Guid.NewGuid(),
                    Amount = dto.Amount,
                    TransactionTypeId = dto.TransactionTypeId,
                    ClientId = client.Id,
                    CardId = card.Id,
                    MerchantId = merchant.Id,
                    TransactedAt = dto.TransactedAt,
                });
                _db.SaveChanges();
                return result.Good("Transação salva com sucesso");

            }
            catch (Exception e)
            {
                return result.Bad(e);
            }
        }

        public TransactionImportedRowDto ParseRowFromFile(string row)
        {
            var result = new TransactionImportedRowDto()
            {
                TransactionTypeId = Convert.ToInt32(row.Substring(0, 1)),

                TransactedAt = Convert.ToDateTime($"{row.Substring(1, 4)}-{row.Substring(5, 2)}-{row.Substring(7, 2)} {row.Substring(42, 2)}:{row.Substring(44, 2)}:{row.Substring(46, 2)}"),

                Amount = Convert.ToDecimal(row.Substring(9, 10)) / 100,

                CPF = row.Substring(19, 11),

                CardNumber = row.Substring(30, 12),

                StoreOwnerName = row.Substring(48, 14).Trim(),

                StoreName = row.Substring(62, row.Length - 62),
            };
            return result;
        }
    }
}
