using Entity.Concete;

namespace Business.Abstract;

public interface ICourseService : IGenericService<Course>
{
    public List<Course> GetCoursesWithNames();
}