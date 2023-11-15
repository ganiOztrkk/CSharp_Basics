using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;

ICourseService _courseService = new CourseManager(new EfCourseDal());

var courses = _courseService.GetCoursesWithNames();



courses.ForEach(x =>
{
    Console.WriteLine($"{x.Id} - {x.Title} - {x.Category.Name} - {x.Instructor.Name}");
});
