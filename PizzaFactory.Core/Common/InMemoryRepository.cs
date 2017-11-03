using PizzaFactory.Infrastructure;
using System;
using System.Collections.Generic;

namespace PizzaFactory.Core.Common
{
    public class InMemoryRepository : IRepository
    {
        InMemoryData data = InMemoryData.Instance;

        public TEntity Load<TEntity>(Guid id) where TEntity : EntityBase<Guid>
        {
            IEntitiesSet<TEntity> entitiesSet = data.Set<TEntity>();

            return entitiesSet.Find(id);
        }
        public void Save<TEntity>(TEntity aggregate, string createdBy) where TEntity : EntityBase<Guid>
        {
            IEntitiesSet<TEntity> entitiesSet = data.Set<TEntity>();

            entitiesSet.Add(aggregate);
        }
        public bool Any<TEntity>(Guid id) where TEntity : EntityBase<Guid>
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TEntity> All<TEntity>() where TEntity : EntityBase<Guid>
        {
            IEnumerable<TEntity> entities = data.Set<TEntity>().Local;

            return entities;
        }        
        public void Delete<TEntity>(TEntity aggregate, string deletedBy) where TEntity : EntityBase<Guid>
        {
            throw new NotImplementedException();
        }
    }
}
