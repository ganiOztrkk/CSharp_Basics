using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;

ICourseService _courseService = new CourseManager(new EfCourseDal());


var courses =  _courseService.GetList();

foreach (var item in courses)
{
    Console.WriteLine(item.Title + "||" + item.Description);
}