using System.Data;
using System.Data.SqlClient;

namespace Repository.DbConnection
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public void OpenConnection()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Smeštaji;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
        }

        public bool isReady()
        {
            return connection != null && connection.State != ConnectionState.Closed;
        }

        public SqlCommand CreateCommand(string command = "")
        {
            if (transaction == null)
            {
                transaction = connection.BeginTransaction();
            }
            return new SqlCommand(command, connection, transaction);
        }
        public void Commit()
        {
            transaction.Commit();
        }
        public void Rollback()
        {
            transaction.Rollback();
        }
        public void Close()
        {
            connection.Close();
            transaction.Dispose();
            transaction = null;
        }
    }
}
