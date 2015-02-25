using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Account
    {
        public Person Person { get; set; }
        public string AccountType { get; set; }
        public int AccountNo { get; set; }
        public int SortCode { get; set; }
        public int Balance { get; set; }
        public int Overdraft { get; set; }
    }
}
