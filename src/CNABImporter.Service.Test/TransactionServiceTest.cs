using CNABImporter.Data.Context;
using CNABImporter.Models.Service.Dtos;
using CNABImporter.Service.Interfaces;
using CNABImporter.Service.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CNABImporter.Service.Test
{
    [TestClass]
    public class TransactionServiceTest
    {
        private readonly ITransactionService _transactionService;
        public TransactionServiceTest()
        {
            
            _transactionService = new TransactionService(Config.ConfigContext.GetInMemory());
        }

        [TestMethod]
        [DataRow("2201903010000010700845152540738723****9987123333MARCOS PEREIRAMERCADO DA AVENIDA")]
        [DataRow("1201903010000015200096206760171234****7890233000JOÃO MACEDO   BAR DO JOÃO")]
        [DataRow("3201903010000060200232702980566777****1313172712JOSÉ COSTA    MERCEARIA 3 IRMÃOS")]
        public void ParseRowFromFileTest(string row)
        {
            var res = _transactionService.ParseRowFromFile(row);

            Assert.IsNotNull(res);
        }
        [TestMethod]
        [DataRow("2201903010000010700845152540738723****9987123333MARCOS PEREIRAMERCADO DA AVENIDA")]
        [DataRow("1201903010000015200096206760171234****7890233000JOÃO MACEDO   BAR DO JOÃO")]
        [DataRow("3201903010000060200232702980566777****1313172712JOSÉ COSTA    MERCEARIA 3 IRMÃOS")]
        public void AddTransactionTest(string row)
        {
            var res = _transactionService.AddTransaction(row);
            Assert.IsTrue(res.Success);
        }
    }
}
