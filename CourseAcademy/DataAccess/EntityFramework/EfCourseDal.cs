using Core.GenericRepository.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework;

public class EfCourseDal : EfGenericRepository<Course, Context>, ICourseDal
{
    public List<Course> GetCoursesWithNames()
    {
        using var context = new Context();
        return context.Courses!
            .Include(x => x.Instructor)
            .Include(y => y.Category)
            .ToList();
    }

    public List<DisplayCourseDto> GetCoursesWithNames2()
    {
        using var context = new Context();
        var result = from co in context.Courses
            join ca in context.Categories 
                on co.CategoryId equals ca.Id
            join i in context.Instructors 
                on co.InstructorId equals i.Id
            select new DisplayCourseDto()
            {
                Id = co.Id,
                CategoryName = ca.Name,
                InstructorName = i.Name,
                Title = co.Title,
                Description = co.Description,
                Price = co.Price,
                ImageUrl = co.ImageUrl
            };
        return result.ToList();
    }
}