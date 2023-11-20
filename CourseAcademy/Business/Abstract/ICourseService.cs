using Core.Utilities.Results;
using Entity.Concete;
using Entity.DTOs;

namespace Business.Abstract;

public interface ICourseService : IGenericService<Course>
{
    public IDataResult<List<Course>> GetCoursesWithNames();
    public IDataResult<List<DisplayCourseDto>> GetCoursesWithNames2();
}