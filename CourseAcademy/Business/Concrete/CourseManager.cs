using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concete;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Insert(Course entity)
    {
        _courseDal.Insert(entity);
    }

    public void Delete(Course entity)
    {
        _courseDal.Delete(entity);
    }

    public void Update(Course entity)
    {
        _courseDal.Update(entity);
    }

    public Course? GetById(int id)
    {
        return _courseDal.GetById(id);
    }

    public List<Course> GetList()
    {
        return _courseDal.GetList();
    }

    public List<Course> GetCoursesWithNames()
    {
        return _courseDal.GetCoursesWithNames();
    }
}