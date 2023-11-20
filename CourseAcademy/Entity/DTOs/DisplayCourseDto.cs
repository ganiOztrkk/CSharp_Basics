namespace Entity.DTOs;

public class DisplayCourseDto
{
    public int Id { get; set; }
    public string? CategoryName { get; set; }
    public string? InstructorName { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? ImageUrl { get; set; } 
}