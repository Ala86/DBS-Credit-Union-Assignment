using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Configuration;

namespace AssignmentWeek1
{
    public class PresentaionMethods
    {
        public string EmptyNotifier(string input, string field)
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

        public string EmailValidator(string emailInput)
        {
            string message = null;
            string EmailRegEx = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+(?:[A-Z]{2}|com|org|net|edu|gov|mil|biz|info|mobi|name|aero|asia|jobs|museum)\b";

            if (Regex.IsMatch(emailInput,EmailRegEx))
	        {
	        	message = null; 
	        }
            else
	        {
                message = "Email entered is invalid" + Environment.NewLine;
	        }

            return message;
        }
        public string PhoneValidator(string phoneInput)
        {
            string message = null;
            string phoneRegEx = ConfigurationManager.AppSettings["PhoneRegEx"];
            
            if (Regex.IsMatch(phoneInput, phoneRegEx))
            {
                message = null;
            }
            else
            {
                message = "Please enter phone in XXX-XXXXXXX or XX-XXXXXX format" + Environment.NewLine;
            }

            return message;
        }
    }
}
