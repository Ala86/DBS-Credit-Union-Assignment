using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Model;

namespace DAL
{
    public class DbInteractions
    {

        public string sortCode = ConfigurationManager.AppSettings["SortCode"];
        

        string configcxn = ConfigurationManager.ConnectionStrings["myCxnStr"].ConnectionString;
        //Create class User
        public bool UserLogin(string password, string userName)
        {
            bool result = false;
           
            using (SqlConnection cxn = new SqlConnection(configcxn))
            {
                SqlDataReader dr = null;
                SqlCommand cmd = new SqlCommand("spLogin", cxn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter userNameParam = new SqlParameter("@userName", SqlDbType.NVarChar, 50);
                userNameParam.Value = userName;
                cmd.Parameters.Add(userNameParam);
                 
                SqlParameter userPassParam = new SqlParameter("@userPass", SqlDbType.NVarChar, 400);
                userPassParam.Value = password;
                cmd.Parameters.Add(userPassParam);

                

                cxn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    result = true;
                }
                dr.Close();
                cxn.Close();
                return result;
            }
            
        }
        //Create class user
        public bool RegisterUser(string firstName, string lastName, string userName, string password)
        {

                using (SqlConnection cxn = new SqlConnection(configcxn))
                {
                    //Have to check existing accounts first, using login stored procedure to return 

                    SqlCommand cmd = cxn.CreateCommand();
                    cmd.Parameters.Add("@userFName", SqlDbType.NVarChar, 50).Value = firstName;
                    cmd.Parameters.Add("@userLName", SqlDbType.NVarChar, 50).Value = lastName;
                    cmd.Parameters.Add("@userName", SqlDbType.NVarChar, 50).Value = userName;
                    cmd.Parameters.Add("@userPass", SqlDbType.NVarChar, 400).Value = password;
                    cmd.Parameters.Add("@userId", SqlDbType.Int).Direction = ParameterDirection.Output;

                   
                    cmd.CommandText = "spInsertUser";

                    cmd.CommandType = CommandType.StoredProcedure;

                    cxn.Open();

                    cmd.ExecuteNonQuery();

                    cxn.Close();
                    
                    //Stored new userId
                    int newUserId = Convert.ToInt32(cmd.Parameters["@userId"].Value);

                    if (newUserId > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
        }

        public bool NewCustomer(Person person)
        {
            int newUserId = 0;

            string firstName = person.FName;
            string lastName = person.LName;
            string email = person.Email;
            string phone = person.Phone;
            string address1 = person.Address1;
            string address2 = person.Address2;
            string city = person.City;
            string county = person.County;
            

            using (SqlConnection cxn = new SqlConnection(configcxn))
            {
                //Have to check existing accounts first, using login stored procedure to return 

                SqlCommand cmd =  new SqlCommand("spNewCustomer", cxn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@FName", SqlDbType.NVarChar, 70).Value = firstName;
                cmd.Parameters.Add("@LName", SqlDbType.NVarChar, 70).Value = lastName;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = email;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = phone;
                cmd.Parameters.Add("@Address1", SqlDbType.NVarChar, 100).Value = address1;
                cmd.Parameters.Add("@Address2", SqlDbType.NVarChar, 100).Value = address2;
                cmd.Parameters.Add("@City", SqlDbType.NVarChar, 100).Value = city;
                cmd.Parameters.Add("@County", SqlDbType.NVarChar, 50).Value = county;
                

                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Direction = ParameterDirection.Output;

               

               
                cxn.Open();
                cmd.ExecuteNonQuery();
                cxn.Close();
                newUserId = Convert.ToInt32(cmd.Parameters["@CustomerId"].Value);
                
            }
            if (newUserId > 0)
            {
               person.CustomerId = newUserId;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Person FindCustomer(Person person)
        {
            

            using (SqlConnection cxn = new SqlConnection(configcxn))
            {
                SqlCommand cmd = new SqlCommand("spFindCustomer", cxn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = person.CustomerId;

                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 70).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 70).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Address1", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Address2", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@City", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@County", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;

                cxn.Open();
                cmd.ExecuteNonQuery();
                cxn.Close();

                person.FName = Convert.ToString(cmd.Parameters["@FirstName"].Value);
                person.LName = Convert.ToString(cmd.Parameters["@LastName"].Value);
                person.Email = Convert.ToString(cmd.Parameters["@Email"].Value);
                person.Phone = Convert.ToString(cmd.Parameters["@Phone"].Value);
                person.Address1 = Convert.ToString(cmd.Parameters["@Address1"].Value);
                person.Address2 = Convert.ToString(cmd.Parameters["@Address2"].Value);
                person.City = Convert.ToString(cmd.Parameters["@City"].Value);
                person.County = Convert.ToString(cmd.Parameters["@County"].Value);
            }

            return person;
        }

        public bool NewAccount(Account account)
        {
            int accountNum = account.AccountNo;
            int balance = account.Balance;
            string accountType = account.AccountType;
            //int sort = account.SortCode;
            
            int overdraft = account.Overdraft;
            int customerId = account.Person.CustomerId;
            int rows;

            using (SqlConnection cxn = new SqlConnection(configcxn))
            {
                SqlCommand cmd = new SqlCommand("spNewAccount", cxn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@AccountId", SqlDbType.Int).Value = accountNum;
                cmd.Parameters.Add("@AccountType", SqlDbType.NVarChar, 50).Value = accountType;
                cmd.Parameters.Add("@Sort", SqlDbType.Int).Value = int.Parse(sortCode);
                cmd.Parameters.Add("@Balance", SqlDbType.Int).Value = balance;
                cmd.Parameters.Add("@Overdraft", SqlDbType.Int).Value = overdraft;
                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;

                cxn.Open();
                rows = cmd.ExecuteNonQuery();
                cxn.Close();

                if (rows > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

        }
        
        public Account PopulateDetails(Account account)
        {
            Person person = new Person();
        
            using (SqlConnection cxn = new SqlConnection(configcxn))
            {
                
                SqlCommand cmd = new SqlCommand("spFindAccountDetails", cxn); //cxn.CreateCommand();
               // cmd.CommandText = ("spFindAccountDetails");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@AccountId", SqlDbType.Int).Value = account.AccountNo;

                   //Output parameters for object person (a property of object account)
                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 70).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 70).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Address1", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Address2", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@City", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@County", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Direction = ParameterDirection.Output;    
                //Output parameters of object account
                cmd.Parameters.Add("@Sort", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Balance", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Overdraft", SqlDbType.Int).Direction = ParameterDirection.Output;
   
                //Executing query + openclose connection
                cxn.Open();
                cmd.ExecuteNonQuery();
                cxn.Close();

                //Assigning values to object person    
                person.FName = Convert.ToString(cmd.Parameters["@FirstName"].Value);
                person.LName = Convert.ToString(cmd.Parameters["@LastName"].Value);
                person.Email = Convert.ToString(cmd.Parameters["@Email"].Value);
                person.Phone = Convert.ToString(cmd.Parameters["@Phone"].Value);
                person.Address1 = Convert.ToString(cmd.Parameters["@Address1"].Value);
                person.Address2 = Convert.ToString(cmd.Parameters["@Address2"].Value);
                person.City = Convert.ToString(cmd.Parameters["@City"].Value);
                person.County = Convert.ToString(cmd.Parameters["@County"].Value);
                person.CustomerId = Convert.ToInt32(cmd.Parameters["@CustomerId"].Value);
                //Assigning values to object Account
                account.Person = person;
                account.SortCode = Convert.ToInt32(cmd.Parameters["@Sort"].Value);
                account.Balance = Convert.ToInt32(cmd.Parameters["@Balance"].Value);
                account.Overdraft = Convert.ToInt32(cmd.Parameters["@Overdraft"].Value);
                }
                
            //Returning account with assigned details
                return account;
                
            }

        public DataSet DisplayAccountsLastName()
        {
            DataSet ds = null;

            using (SqlConnection cxn = new SqlConnection(configcxn))
            {
                SqlCommand cmd = new SqlCommand("spDisplayAccountsLastName", cxn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
               
                cxn.Open();
                da.SelectCommand = cmd;
                ds.Clear();
                da.Fill(ds);
                cxn.Close();

            }

            return ds;
        }

        public DataSet DisplayTransactions()
        {
            DataSet ds = null;

            using (SqlConnection cxn = new SqlConnection(configcxn))
            {
                SqlCommand cmd = new SqlCommand("spDisplayTransactions", cxn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                cxn.Open();
                da.SelectCommand = cmd;
                ds.Clear();
                da.Fill(ds);
                cxn.Close();  
            
            }
            return ds;
        
        }

        public DataSet DisplayIntTransfers()
        {
            DataSet ds = null;

            using (SqlConnection cxn = new SqlConnection(configcxn))
            {
                SqlCommand cmd = new SqlCommand("spDisplayInternalTransfers", cxn);
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                cxn.Open();
                da.SelectCommand = cmd;
                ds.Clear();
                da.Fill(ds);
                cxn.Close();

            }
            return ds;

        }
        
        public bool UpdateAccountBalance(Account acc)
        {
            int rowsAffected;
            int newBalance = acc.Balance;
            int accountId = acc.AccountNo;

            using (SqlConnection cxn = new SqlConnection(configcxn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateBalance", cxn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NewBalance", SqlDbType.Int).Value = newBalance;
                cmd.Parameters.Add("@AccountId", SqlDbType.Int).Value = accountId;

                cxn.Open();
                rowsAffected =cmd.ExecuteNonQuery();
                cxn.Close();
              

            }
            if (rowsAffected > 0)
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

            TransactionStore(transfer.Sender);
            TransactionStore(transfer.Receiver);
            bool check3 = TransferStoreMethod(transfer);

            return check3;

        }
        private bool TransferStoreMethod(Transfer transfer)
        { 
            int rowsAffected;
            using(SqlConnection cxn = new SqlConnection(configcxn))
            {
                SqlCommand cmd = new SqlCommand("spTransferStore",cxn);
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TransactionIdSender",SqlDbType.Int).Value = transfer.Sender.TransactionId;
                cmd.Parameters.Add("@TransactionIdReceiver",SqlDbType.Int).Value = transfer.Receiver.TransactionId;
                cmd.Parameters.Add("@TransDescription", SqlDbType.NVarChar, 200).Value = transfer.Description;
                cmd.Parameters.Add("@TransferId", SqlDbType.Int).Direction = ParameterDirection.Output;

                cxn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                cxn.Close();

                transfer.TransferId = Convert.ToInt32(cmd.Parameters["@TransferId"].Value);

            }
            if (rowsAffected >0)
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
            int rowsAffected;

            using(SqlConnection cxn = new SqlConnection(configcxn))
            {
                SqlCommand cmd = new SqlCommand("spTransactionStore",cxn);
                
                cmd.CommandType = CommandType.StoredProcedure;
                
                // Maybe need to output the transction id to fully build the transaction object

                cmd.Parameters.Add("@AccountId",SqlDbType.Int).Value = transaction.Actor.AccountNo;
                cmd.Parameters.Add("@Amount",SqlDbType.Int).Value = transaction.Amount;
                cmd.Parameters.Add("@DateTimeStamp",SqlDbType.DateTime).Value = transaction.TimeStamp;
                cmd.Parameters.Add("@TransactionType", SqlDbType.NVarChar,50).Value = transaction.TransactionType;
                cmd.Parameters.Add("@TransactionId", SqlDbType.NVarChar, 200).Direction = ParameterDirection.Output;
                cxn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                cxn.Close();

                transaction.TransactionId = Convert.ToInt32(cmd.Parameters["@TransactionId"].Value);
                
            }

            if (rowsAffected > 0)
            {
                return transaction;
            }
            else
            {
                return transaction = null;
            }
         }

        }
    }

