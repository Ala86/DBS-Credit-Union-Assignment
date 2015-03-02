using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class Methods
    {
        HashCode hc = new HashCode();
        DbInteractions dbInt = new DbInteractions();

        public bool UserLogin(string password, string userName)
        {
            

            string encryptPass = hc.PassHash(password);

            

            if (dbInt.UserLogin(encryptPass, userName)) 
            {
                return true;
            }
            else 
            {
            return false;
            }
        }

        public bool RegisterUser(Employee emp)
        {
            string encryptPass = hc.PassHash(emp.Password);
            emp.Password = encryptPass;

            if (dbInt.RegisterUser(emp))
            {
                return true;
            }
            else
            {
                return false;
            }
 
        }

        public bool NewCustomer(Person person)
        {

            if (dbInt.NewCustomer(person))
            { 
                return true; 
            }
            else 
            {
                return false;
            }

        }

        public Person FindCustomer(Person person)
        {
            

            person = dbInt.FindCustomer(person);

            return person;
            
        }

        public bool NewAccount(Account account)
        {
            Random rd = new Random();

            //Need to put in a selection to test this
            account.AccountNo = rd.Next(10000000, 99999999);

            if (dbInt.NewAccount(account))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Account PopulateDetails(Account account)
        {
            return dbInt.PopulateDetails(account);
        }

        public DataSet DisplayAccountsLastName()
        {
            DataSet ds = dbInt.DisplayAccountsLastName();

            return ds;
        }

        public DataSet DisplayTransactions()
        {
            DataSet ds = dbInt.DisplayTransactions();

            return ds;
        }

        public DataSet DisplayIntTransfers()
        {
            DataSet ds = dbInt.DisplayIntTransfers();

            return ds;
        }


        public bool UpdateAccountBalance(int amount, Account acc)
        {
            acc.Balance = acc.Balance + amount;

            if (dbInt.UpdateAccountBalance(acc))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferStore(Transfer transfer)
        {
            if (dbInt.TransferStore(transfer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Transaction TransactionStore(Transaction transaction)
        {
            if (dbInt.TransactionStore(transaction) != null)
            {
                return transaction;
            }
            else
            {
                return transaction = null;
            }
        }

        public bool EditAccountDetails(string email, string phone, string address1, string address2, string city, string county, int overdraft, Account acc)
        {
            acc.Person.Email = email;
            acc.Person.Phone = phone;
            acc.Person.Address1 = address1;
            acc.Person.Address2 = address2;
            acc.Person.City = city;
            acc.Person.County = county;

            if (dbInt.EditAccountDetails(acc))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
    }
}
