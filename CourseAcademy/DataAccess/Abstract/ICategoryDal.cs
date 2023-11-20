using Core.GenericRepository.Abstract;
using Entity.Concete;

namespace DataAccess.Abstract;

public interface ICategoryDal : IEntityRepository<Category>
{
    //sadece bana özgü işler var
}