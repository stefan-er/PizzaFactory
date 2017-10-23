using System.Linq;

namespace PizzaFactory.Infrastructure
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;

        T Load<T>(object id) where T : class;

        void Save<T>(T aggregate, string createdBy) where T : class;

        void Delete<T>(T aggregate, string deletedBy) where T : class;

        bool Any<T>(object id) where T : class, IEntity<object>;
    }
}
