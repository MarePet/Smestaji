namespace Repository.Interfaces
{
    public interface IDbRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        void Commit();
        void Rollback();
        void Close();
    }
}
