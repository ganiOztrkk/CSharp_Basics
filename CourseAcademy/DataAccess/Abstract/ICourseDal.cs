using Core.GenericRepository.Abstract;
using Entity.Concete;
using Entity.DTOs;

namespace DataAccess.Abstract;

public interface ICourseDal : IEntityRepository<Course>
{
    public List<Course> GetCoursesWithNames();
    
    public List<DisplayCourseDto> GetCoursesWithNames2();
}