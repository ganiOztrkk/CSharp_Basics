using Entity.Abstract;

namespace Entity.Concete;

public class Course : IEntity
{
    public int Id { get; set; }
    
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    
    
    public int InstructorId { get; set; }
    public Instructor? Instructor { get; set; }//migration için ilişki
    
    
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? ImageUrl { get; set; } //nullable
}