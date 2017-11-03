using System;
using System.Collections.Generic;

namespace PizzaFactory.Infrastructure
{
    public interface IRepository
    {
        TEntity Load<TEntity>(Guid id) where TEntity : EntityBase<Guid>;

        void Save<TEntity>(TEntity aggregate, string createdBy) where TEntity : EntityBase<Guid>;

        bool Any<TEntity>(Guid id) where TEntity : EntityBase<Guid>;

        IEnumerable<TEntity> All<TEntity>() where TEntity : EntityBase<Guid>;

        void Delete<TEntity>(TEntity aggregate, string deletedBy) where TEntity : EntityBase<Guid>;
    }
}
