using Core.GenericRepository.Abstract;

namespace Entity.Concete;


public class Category  : IEntity // bu bir tablodur
{
    public int Id { get; set; }
    public string? Name { get; set; }
    
    

    public List<Course>? Courses { get; set; }
}