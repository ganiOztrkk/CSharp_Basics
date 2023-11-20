using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;

ICourseService _courseService = new CourseManager(new EfCourseDal());

var courses = _courseService.GetCoursesWithNames();
var courses2 = _courseService.GetCoursesWithNames2();


courses.Data!.ForEach(x =>
{
    Console.WriteLine($"{x.Title} - {x.Category!.Name} - {x.Instructor!.Name}");    
});
Console.WriteLine("@@@@@@@@@@@@@@");
courses2.Data!.ForEach(x =>
{
    Console.WriteLine($"{x.Title} - {x.CategoryName} - {x.InstructorName}");
});
