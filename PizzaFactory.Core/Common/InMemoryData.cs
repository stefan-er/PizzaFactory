﻿using PizzaFactory.Core.Orders;
using PizzaFactory.Infrastructure;
using System;
using System.Collections.Generic;

namespace PizzaFactory.Core.Common
{
    public class InMemoryData
    {
        private static readonly InMemoryData instance = new InMemoryData();
        private IDictionary<Type, object> sets;

        private InMemoryData()
        {
            sets = new Dictionary<Type, object>();
            
            sets[typeof(Order)] = new EntitiesSet<Order>();
        }

        public static InMemoryData Instance
        {
            get
            {
                return instance;
            }
        }
        
        public IEntitiesSet<TEntity> Set<TEntity>() where TEntity : EntityBase<Guid>
        {
            IEntitiesSet<TEntity> set = null;

            Type entityType = typeof(TEntity);
            if (sets.ContainsKey(entityType))
            {
                set = sets[entityType] as IEntitiesSet<TEntity>;
            }

            return set;
        }
    }
}
