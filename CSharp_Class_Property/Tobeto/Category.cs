namespace Tobeto;

public class Category // category türü -- bu bir tablo
{
    public int Id { get; set; } // primary key
    public Course[]? Courses { get; set; } // bir kategori, birden fazla kurs alabilir. 
    //public List<Course>? Courses { get; set; }
    
    public string? Name { get; set; }
}