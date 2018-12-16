﻿namespace Repository.Interfaces
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;

    #endregion

    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}