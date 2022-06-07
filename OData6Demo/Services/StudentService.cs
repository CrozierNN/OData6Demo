using OData6Demo.Models;

namespace OData6Demo.Services;

public class StudentService : IStudentService
{
    public IQueryable<Student> RetrieveAllStudents()
    {

        return new List<Student>()
        {
            new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Vishu Goli",
                Score = 200,
            },
            new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Glan Gee",
                Score = 134,
            },
            new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Kailu Hu",
                Score = 150,
            },
            new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Spoko Bella",
                Score = 95,
            },
        }.AsQueryable();
        
    }
}
