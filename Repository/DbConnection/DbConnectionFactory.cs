namespace Repository.DbConnection
{
    public class DbConnectionFactory
    {
        private static DbConnectionFactory instance;
        private DbConnection connection = new DbConnection();

        public static DbConnectionFactory Instance
        {
            get
            {
                if (instance == null) instance = new DbConnectionFactory();
                return instance;
            }
        }
        private DbConnectionFactory() { }

        public DbConnection GetDbConnection()
        {
            if (!connection.isReady())
            {
                connection.OpenConnection();
            }
            return connection;
        }
    }
}
