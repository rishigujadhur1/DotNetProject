using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly CourseContext context;

        public CourseController(CourseContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetCourses()
        {
            return await context.Courses.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            return await context.Courses.FindAsync(id);
        }
		
        [HttpPatch]
        public async Task<Course> UpdateCourseAsync(Course course)
        {
            context.Update(course);
            await context.SaveChangesAsync();
            return course;
        }

        [HttpDelete]
        public async Task<Course> DeleteCourseAsync(Course course)
        {
            context.Remove(course);
            await context.SaveChangesAsync();
            return course;
        }
    }
}