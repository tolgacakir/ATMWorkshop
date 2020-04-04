using ATM.DataAccessLayer.Abstract;
using ATM.Model.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Concrete.AdoNetDal
{
    public class AdoNetAccountDal : IAccountDal
    {
        private string _connectionString;

        public AdoNetAccountDal()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SQLDB"].ConnectionString;
        }

        public bool Delete(Account entity)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string commandText = "DELETE FROM ACCOUNTS WHERE IBAN = @iban";
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@iban", entity.Iban);
                    result = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return result > 0;
        }

        public Account GetByPrimaryKey(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IList<Account> GetList()
        {
            IList<Account> accounts = new List<Account>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string commandText = "SELECT * FROM ACCOUNTS";
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(new Account
                            {
                                Iban = reader["IBAN"].ToString(),
                                Balance = decimal.Parse(reader["BALANCE"].ToString()),
                                Credit = decimal.Parse(reader["BALANCE"].ToString()),
                                IsDefault = bool.Parse(reader["DEFAULT"].ToString()),
                                Owner = reader["OWNER"].ToString(),
                                Type = AccountType.Basic,
                            });
                        }
                    }
                }
            }
            return accounts;
        }

        public bool Insert(Account entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
