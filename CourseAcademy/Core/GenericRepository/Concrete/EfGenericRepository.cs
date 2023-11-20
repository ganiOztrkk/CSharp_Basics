using Core.GenericRepository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.GenericRepository.Concrete;

public class EfGenericRepository<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    public void Insert(TEntity entity)
    {
        using TContext context = new TContext();
        context.Add(entity);
        context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        using TContext context = new TContext();
        context.Remove(entity);
        context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        using TContext context = new TContext();
        context.Update(entity);
        context.SaveChanges();
    }
    
    //var deletedEntity = context.Entry(entity);
    //deletedEntity.State = EntityState.Deleted;

    public TEntity? GetById(int id)
    {
        using TContext context = new TContext();
        return context.Set<TEntity>().Find(id);
        
        //return context.Set<Product>().SingleOrDefault(filter)!;
    }

    public List<TEntity> GetList()
    {
        using TContext context = new TContext();
        return context.Set<TEntity>().ToList();
    }
}