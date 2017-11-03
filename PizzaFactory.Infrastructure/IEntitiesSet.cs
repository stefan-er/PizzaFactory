using System;
using System.Collections.Generic;

namespace PizzaFactory.Infrastructure
{
    public interface IEntitiesSet<TEntity> where TEntity : EntityBase<Guid>
    {
        IEnumerable<TEntity> Local { get; }

        TEntity Find(Guid id);
        void Add(TEntity entity);
    }
}
