using System;
using System.Collections.Generic;

namespace PizzaFactory.Infrastructure
{
    public interface IRepository
    {
        IEnumerable<T> All<T>() where T : class;

        T Load<T>(object id) where T : class;

        void Save<T>(T aggregate, string createdBy) where T : EntityBase<Guid>;

        void Delete<T>(T aggregate, string deletedBy) where T : class;

        bool Any<T>(object id) where T : class, IEntity<object>;
    }
}
