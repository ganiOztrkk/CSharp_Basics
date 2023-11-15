using Entity.Concete;

namespace DataAccess.Abstract;

public interface ICourseDal : IGenericDal<Course>
{
    public List<Course> GetCoursesWithNames();
}