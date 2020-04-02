using ATM.DataAccessLayer.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Concrete
{
    public class CustomerRepository : IGenericRepository<Customer>
    {
        private string _connectionString;
        public CustomerRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SQLDB"].ToString();
        }
        public bool Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer GetByPrimaryKey(object primaryKey)
        {
            Customer customer = new Customer();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string commandText = "SELECT * FROM CUSTOMERS WHERE USERNAME=@Username";
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@Username", primaryKey);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customer = new Customer
                            {
                                Username = reader["USERNAME"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LASTNAME"].ToString(),
                                Password = reader["PASSWORD"].ToString(),
                                InvalidLoginCount = int.Parse(reader["InvalidLoginCount"].ToString()),
                                Locked = bool.Parse(reader["LOCKED"].ToString()),
                                LoggedIn = bool.Parse(reader["LoggedIn"].ToString()),
                            };
                        }
                    }
                }
            }
            return customer;
        }

        public IList<Customer> GetList()
        {
            IList<Customer> customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string commandText = "SELECT * FROM CUSTOMERS";
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                Username = reader["USERNAME"].ToString(),
                                FirstName = reader["FIRSTNAME"].ToString(),
                                LastName = reader["LASTNAME"].ToString(),
                                Password = reader["PASSWORD"].ToString(),
                                InvalidLoginCount = int.Parse(reader["INVALIDLOGINCOUNT"].ToString()),
                                Locked = bool.Parse(reader["LOCKED"].ToString()),
                                LoggedIn = bool.Parse(reader["LOGGEDIN"].ToString()),
                            });
                        }
                    }
                }
            }
            return customers;
        }

        public bool Insert(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
