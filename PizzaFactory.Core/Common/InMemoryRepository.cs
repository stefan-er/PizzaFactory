using PizzaFactory.Core.Orders;
using PizzaFactory.Infrastructure;
using System;
using System.Collections.Generic;

namespace PizzaFactory.Core.Common
{
    public class InMemoryRepository : IRepository
    {
        InMemoryData data = InMemoryData.Instance;

        public T Load<T>(object id) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> All<T>() where T : class
        {
            IEnumerable<T> entities = null;

            if (typeof(T).Equals(typeof(Order)))
            {
                entities = (IEnumerable<T>)data.Orders.Values;
            }

            return entities;
        }
        
        bool IRepository.Any<T>(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T aggregate, string deletedBy) where T : class
        {
            throw new NotImplementedException();
        }


        public void Save<T>(T aggregate, string createdBy) where T : EntityBase<Guid>
        {
            if (typeof(T).Equals(typeof(Order)))
            {
                Order order = aggregate as Order;
                data.Orders[order.Id] = order;
            }
        }
    }
}
