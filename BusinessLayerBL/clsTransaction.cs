using DataAccessLayerDAL;
using DataAccessLayerDAL.Interfaces;

namespace BusinessLayerBL
{
    public class clsTransaction
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }

        private readonly ITransactionDataAccess _transactionData;

        public clsTransaction()
        {
            _transactionData = new clsTransactionDAL();
        }

        public bool Add()
        {
           
            return _transactionData.Add(UserID, Amount, TransactionType, CategoryID, DateTime.Now, "") > 0;
        }
    }
}