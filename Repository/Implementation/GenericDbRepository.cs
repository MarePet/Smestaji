using Domain;
using Repository.DbConnection;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository.Implementation
{
    public class GenericDbRepository : IDbRepository<IDomainObject>
    {
        public void Add(IDomainObject entity)
        {
            SqlCommand command = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"INSERT INTO {entity.TableName} VALUES ({entity.InsertValues})");
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Close()
        {
            DbConnectionFactory.Instance.GetDbConnection().Close();
        }

        public void Commit()
        {
            DbConnectionFactory.Instance.GetDbConnection().Commit();
        }

        public void Delete(IDomainObject entity)
        {
            SqlCommand command = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"DELETE {entity.Alias} FROM {entity.TableName} {entity.Alias} {entity.Criteria}");

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IDomainObject Get(IDomainObject entity)
        {
            SqlCommand sqlCommand = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"SELECT {entity.SelectValues} FROM {entity.TableName} {entity.Alias} {entity.Join} {entity.Criteria}");
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                entity = entity.ReadRow(reader);
            }
            reader.Close();
            return entity;
        }

        public List<IDomainObject> GetAll(IDomainObject entity)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"SELECT {entity.SelectValues}  FROM {entity.TableName} {entity.Alias} {entity.Join} {entity.Criteria}");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(entity.ReadRow(reader));
            }
            reader.Close();
            return result;
        }

        public void Rollback()
        {
            DbConnectionFactory.Instance.GetDbConnection().Rollback();
        }

        public List<IDomainObject> Search(IDomainObject entity)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"SELECT {entity.SelectValues} FROM {entity.TableName} {entity.Alias} {entity.Join} {entity.Criteria}");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(entity.ReadRow(reader));
            }
            reader.Close();
            return result;
        }

        public void Update(IDomainObject entity)
        {
            SqlCommand command = DbConnectionFactory.Instance.GetDbConnection().CreateCommand($"UPDATE {entity.TableName} {entity.Criteria}");
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
