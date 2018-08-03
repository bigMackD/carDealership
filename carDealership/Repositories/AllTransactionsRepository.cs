using carDealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Repositories
{
    public class AllTransactionsRepository
    {
        private static List<Transaction> _allTransactions = new List<Transaction>();

        public void AddTransaction(Transaction transaction)
        {
            _allTransactions.Add(transaction);
        }
        public void RemoveTransaction(int index)
        {
            _allTransactions.RemoveAt(index);
        }
        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _allTransactions;
        }

    }
}
