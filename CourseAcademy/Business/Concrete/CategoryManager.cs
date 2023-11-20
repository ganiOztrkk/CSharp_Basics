using Business.Abstract;
using Core.Utilities.Results;
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


    public IResult Insert(Category entity)
    {
        _categoryDal.Insert(entity);
        return new SuccessResult();
    }

    public IResult Delete(Category entity)
    {
        _categoryDal.Delete(entity);
        return new SuccessResult();
    }

    public IResult Update(Category entity)
    {
        _categoryDal.Update(entity);
        return new SuccessResult();
    }

    public IDataResult<Category?> GetById(int id)
    {
        return new SuccessDataResult<Category?>(_categoryDal.GetById(id));
    }

    public IDataResult<List<Category>> GetList()
    {
        return new SuccessDataResult<List<Category>>(_categoryDal.GetList());
    }
}