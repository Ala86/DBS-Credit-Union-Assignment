using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        public Account Actor { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        
    }
}
