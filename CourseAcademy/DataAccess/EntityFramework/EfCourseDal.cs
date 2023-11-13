using DataAccess.Abstract;
using Entity.Concete;

namespace DataAccess.EntityFramework;

public class EfCourseDal : GenericRepository<Course>, ICourseDal
{
    
}