using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework;

public class EfCourseDal : GenericRepository<Course>, ICourseDal
{
    public List<Course> GetCoursesWithNames()
    {
        using var context = new Context();
        return context.Courses!
            .Include(x => x.Instructor)
            .Include(y => y.Category)
            .ToList();
    }
    //include bir linq sorgusudur
}