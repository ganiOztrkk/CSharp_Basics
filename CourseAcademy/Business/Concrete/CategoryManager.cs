using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concete;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }


    public void Insert(Category entity)
    {
        _categoryDal.Insert(entity);
    }

    public void Delete(Category entity)
    {
        _categoryDal.Delete(entity);
    }

    public void Update(Category entity)
    {
        _categoryDal.Update(entity);
    }

    public Category? GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public List<Category> GetList()
    {
        return _categoryDal.GetList();
    }
}