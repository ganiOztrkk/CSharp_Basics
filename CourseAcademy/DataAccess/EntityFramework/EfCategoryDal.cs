using DataAccess.Abstract;
using Entity.Concete;

namespace DataAccess.EntityFramework;

public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
{
    
}