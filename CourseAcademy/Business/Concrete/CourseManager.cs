using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concete;
using Entity.DTOs;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public IResult Insert(Course entity)
    {
        _courseDal.Insert(entity);
        return new SuccessResult();
    }

    public IResult Delete(Course entity)
    {
        _courseDal.Delete(entity);
        return new SuccessResult();
    }

    public IResult Update(Course entity)
    {
        _courseDal.Update(entity);
        return new SuccessResult();
    }

    public IDataResult<Course?> GetById(int id)
    {
        return new SuccessDataResult<Course?>(_courseDal.GetById(id));
    }

    public IDataResult<List<Course>> GetList()
    {
        return new SuccessDataResult<List<Course>>(_courseDal.GetList());
    }

    public IDataResult<List<Course>> GetCoursesWithNames()
    {
        return new SuccessDataResult<List<Course>>(_courseDal.GetCoursesWithNames());
    }

    public IDataResult<List<DisplayCourseDto>> GetCoursesWithNames2()
    {
        return new SuccessDataResult<List<DisplayCourseDto>>(_courseDal.GetCoursesWithNames2());
    }
}