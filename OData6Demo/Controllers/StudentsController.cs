using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OData6Demo.Models;
using OData6Demo.Services;

namespace OData6Demo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private IStudentService studentService;

    public StudentsController(IStudentService studentService) =>
        this.studentService = studentService;

    [HttpGet]
    [EnableQuery]
    public ActionResult<IQueryable<Student>> GetAllStudents()
    {
        var retrieviedStudents = this.studentService.RetrieveAllStudents();

        return Ok(retrieviedStudents);
    }
}
