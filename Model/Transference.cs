using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Transference
    {
        public Transaction Sender { get; set; }
        public Transaction Receiver { get; set; }
        public int TransferId { get; set; }
        public string Description { get; set; }


    }
}
    