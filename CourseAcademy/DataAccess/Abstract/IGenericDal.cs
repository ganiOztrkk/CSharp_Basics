using System.Linq.Expressions;
using Entity.Abstract;

namespace DataAccess.Abstract;

public interface IGenericDal<T> where T: class, IEntity, new()
{
    public void Insert(T entity);
    public void Delete(T entity);
    public void Update(T entity);
    public T? GetById(int id);
    public List<T> GetList();
    
    //T Get(Expression<Func<T,bool>> filter);
}