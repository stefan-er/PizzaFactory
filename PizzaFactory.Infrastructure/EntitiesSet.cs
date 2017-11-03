using System;
using System.Collections.Generic;

namespace PizzaFactory.Infrastructure
{
    public class EntitiesSet<TEntity> : IEntitiesSet<TEntity> where TEntity : EntityBase<Guid>
    {
        private IDictionary<Guid, TEntity> entities;

        public EntitiesSet()
        {
            entities = new Dictionary<Guid, TEntity>();
        }

        public IEnumerable<TEntity> Local
        {
            get
            {
                return entities.Values;
            }
        }

        public void Add(TEntity entity)
        {
            entities[entity.Id] = entity;
        }
        public TEntity Find(Guid id)
        {
            TEntity entity = null;

            if (entities.ContainsKey(id))
            {
                entity = entities[id];
            }

            return null;
        }
    }
}
