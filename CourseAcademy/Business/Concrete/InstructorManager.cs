using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concete;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Insert(Instructor entity)
    {
        _instructorDal.Insert(entity);
    }

    public void Delete(Instructor entity)
    {
        _instructorDal.Delete(entity);
    }

    public void Update(Instructor entity)
    {
        _instructorDal.Update(entity);
    }

    public Instructor? GetById(int id)
    {
        return _instructorDal.GetById(id);
    }

    public List<Instructor> GetList()
    {
        return _instructorDal.GetList();
    }
}