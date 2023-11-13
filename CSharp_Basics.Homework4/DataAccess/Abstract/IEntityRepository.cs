using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
