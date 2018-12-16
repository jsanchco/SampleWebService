namespace Repository
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Data.Entities;
    using Interfaces;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.Migrations;

    #endregion

    //public class Repository
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        #region Members

        private bool _disposed;        
        private DbSet<T> _entities;
        private string _errorMessage = string.Empty;

        protected readonly Context Context;

        #endregion

        #region Constuctor

        public Repository()
        {
            Context = new Context();
            _entities = Context.Set<T>();
        }

        public Repository(string connectionString)
        {
            Context = new Context(connectionString);
        }

        #endregion

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public T Get(int id)
        {
            return _entities.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.AddOrUpdate(entity);
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.AddOrUpdate(entity);
            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Remove(entity);
            Context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Remove(entity);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
