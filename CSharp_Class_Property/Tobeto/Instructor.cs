namespace Tobeto;

public class Instructor // bir tablo oluşturduk
{
    public int Id { get; set; } // primary key
    public Course[]? Courses { get; set; } // bir eğitmen, birden fazla kurs alabilir. 
    
    public string? Name { get; set; }
}