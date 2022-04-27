using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentCourses.Models;

namespace StudentCourses.Data
{
    public class StudentCoursesContext : DbContext
    {
        public StudentCoursesContext (DbContextOptions<StudentCoursesContext> options)
            : base(options)
        {
        }

        public DbSet<StudentCourses.Models.CourseModel> CourseModel { get; set; }
    }
}
