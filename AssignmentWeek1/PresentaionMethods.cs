using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentWeek1
{
    public class PresentaionMethods
    {
        public string EmptyChecker(string input, string field)
        {
            string message;

            if (string.IsNullOrEmpty(input))
            {
                message = field + " must be input" + Environment.NewLine;
            }
            else
            {
                message= null;
            }
            return message;
        }
    }
}
