using ATM.DataAccessLayer2.Abstract.GenericRepositories;
using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer2.AdoNetRepositories
{
    public class BaseAdoNetRepository<T> : IGenericRepository<T>
        where T : IEntity
    {
        protected string ConnectionString = ConfigurationManager.ConnectionStrings["SQLDB"].ConnectionString;
        Type Type { get => typeof(T); }
        public virtual void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IList<T> GetList()
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(T entity)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = string.Format("SP_Insert_{0}", Type.Name);
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    PropertyInfo[] propertyInfos = entity.PropertiesForDal;

                    //PropertyInfo[] propertyInfos = Type.GetProperties();
                    foreach (var p in propertyInfos)
                    {
                        command.Parameters.AddWithValue("@" + p.Name, p.GetValue(entity));
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public virtual void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
