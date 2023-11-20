namespace Core.GenericRepository.Abstract;

public interface IEntityRepository <TEntity> where TEntity: class, IEntity, new()
{
    public void Insert(TEntity entity);
    public void Delete(TEntity entity);
    public void Update(TEntity entity);
    public TEntity? GetById(int id);
    public List<TEntity> GetList();
    
    //T Get(Expression<Func<T,bool>> filter);
}