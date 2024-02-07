using Domain;
using Repository.Implementation;
using Repository.Interfaces;
using System;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IDbRepository<IDomainObject> repository;

        public SystemOperationBase()
        {
            repository = new GenericDbRepository();
        }
        public void Execute()
        {
            try
            {
                ExecuteOperation();
                repository.Commit();
            }
            catch (Exception)
            {
                repository.Rollback();
            }
            finally
            {
                repository.Close();
            }
        }
        protected abstract void ExecuteOperation();
    }
}
