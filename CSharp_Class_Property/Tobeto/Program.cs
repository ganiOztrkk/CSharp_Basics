using Tobeto;

Category[] categories = new []
{
    new Category(){Id = 1, Name = "Programlama"},
    new Category(){Id = 2, Name = "Database"},
    new Category(){Id = 3, Name = "Pazarlama"},
    new Category(){Id = 4, Name = "Finans"}
};
Instructor[] instructors = new []
{
    new Instructor(){Id = 1, Name = "Enging Demiroğ"},
    new Instructor(){Id = 2, Name = "Murat Yücedağ"},
    new Instructor(){Id = 3, Name = "Gençay Yıldız"},
    new Instructor(){Id = 4, Name = "Musab Emir"}
};
Course[] courses = new[]
{
    new Course()
    {
        Id = 1,
        CategoryId = 1,
        InstructorId = 1,
        Title = "Programlamaya Giriş",
        Description = "Burası Açıklama alanı",
        ImageUrl = "https://process.fs.teachablecdn",
        Price = 0
    },
    new Course()
    {
    Id = 2,
    CategoryId = 1,
    InstructorId = 1,
    Title = "Programlamaya Giriş",
    Description = "Burası Açıklama alanı",
    ImageUrl = "https://process.fs.teachablecdn",
    Price = 0
    },
    new Course()
    {
        Id = 3,
        CategoryId = 1,
        InstructorId = 1,
        Title = "Programlamaya Giriş",
        Description = "Burası Açıklama alanı",
        ImageUrl = "https://process.fs.teachablecdn",
        Price = 0
    }
    
};

Course newCourse = new Course()
{
    Id = 7,
    CategoryId = 1,
    InstructorId = 1,
    Title = "Programlamaya Giriş",
    Description = "Burası Açıklama alanı",
    ImageUrl = "https://process.fs.teachablecdn",
    Price = 0
};

Console.WriteLine(categories[0].Name);