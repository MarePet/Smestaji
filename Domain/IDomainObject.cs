using System.Data.SqlClient;

namespace Domain
{
    public interface IDomainObject
    {
        string TableName { get; }
        string InsertValues { get; }
        string Criteria { get; }
        string Join { get; }
        string Alias { get; }
        string SelectValues { get; }
        IDomainObject ReadRow(SqlDataReader reader);
    }
}
