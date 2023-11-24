using System.Text.Json.Serialization;
using Core.GenericRepository.Abstract;

namespace Entity.Concete;

public class Course : IEntity
{
    public int Id { get; set; }
    
    
    public int CategoryId { get; set; }
    public virtual Category? Category { get; private set; }
    //migration için ilişki
    
    public int InstructorId { get; set; }
    public virtual Instructor? Instructor { get; private set; }
    //migration için ilişki
    
    
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? ImageUrl { get; set; } 
    // ? = nullable
}