using System;
using System.Linq;

namespace PizzaFactory.Infrastructure
{
    public class InMemoryRepository : IRepository
    {
        public T Load<T>(object id) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> All<T>() where T : class
        {
            throw new NotImplementedException();
        }


        bool IRepository.Any<T>(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T aggregate, string deletedBy) where T : class
        {
            throw new NotImplementedException();
        }


        public void Save<T>(T aggregate, string createdBy) where T : class
        {
            throw new NotImplementedException();
        }

    }
}
