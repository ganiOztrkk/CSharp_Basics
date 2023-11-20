using Business.Abstract;
using Core.Utilities.Results;
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

    public IResult Insert(Instructor entity)
    {
        _instructorDal.Insert(entity);
        return new SuccessResult();
    }

    public IResult Delete(Instructor entity)
    {
        _instructorDal.Delete(entity);
        return new SuccessResult();
    }

    public IResult Update(Instructor entity)
    {
        _instructorDal.Update(entity);
        return new SuccessResult();
    }

    public IDataResult<Instructor?> GetById(int id)
    {
        return new SuccessDataResult<Instructor?>(_instructorDal.GetById(id));
    }

    public IDataResult<List<Instructor>> GetList()
    {
        return new SuccessDataResult<List<Instructor>>(_instructorDal.GetList());
    }
}