using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Abstract;

namespace DataAccess.EntityFramework;

public class GenericRepository<T> : IGenericDal<T> where T: class, IEntity, new()
{
    //Context _context = new Context(); maliyet
    public void Insert(T entity)
    {
        using Context context = new Context();
        context.Add(entity);
        context.SaveChanges();
    }

    public void Delete(T entity)
    {
        using Context context = new Context();
        context.Remove(entity);
        context.SaveChanges();
    }

    public void Update(T entity)
    {
        using Context context = new Context();
        context.Update(entity);
        context.SaveChanges();
    }
    
    //var deletedEntity = context.Entry(entity);
    //deletedEntity.State = EntityState.Deleted;

    public T? GetById(int id)
    {
        using Context context = new Context();
        return context.Set<T>().Find(id);
        
        //return context.Set<Product>().SingleOrDefault(filter)!;
    }

    public List<T> GetList()
    {
        using Context context = new Context();
        return context.Set<T>().ToList();
    }
}