using Core.GenericRepository.Abstract;
using Core.Utilities.Results;


namespace Business.Abstract;

public interface IGenericService<T> where T:class, IEntity, new()
{
    public IResult Insert(T entity);
    public IResult Delete(T entity);
    public IResult Update(T entity);
    public IDataResult<T?> GetById(int id);
    public IDataResult<List<T>> GetList();
}