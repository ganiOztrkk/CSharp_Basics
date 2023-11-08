namespace Tobeto;

public class Course // tablo oluşturdum
{
    public int Id { get; set; }
    public int CategoryId { get; set; } // categorynin foreign key. yani bir kurs bir kategoriye sahiptir.
    public int InstructorId { get; set; } // Instructor foreign key. yani bir kurs bir eğitmen alır.
    
    
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? ImageUrl { get; set; }
    
}