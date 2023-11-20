using Core.GenericRepository.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concete;

namespace DataAccess.EntityFramework;

public class EfCategoryDal : EfGenericRepository<Category, Context>, ICategoryDal
{
    
}