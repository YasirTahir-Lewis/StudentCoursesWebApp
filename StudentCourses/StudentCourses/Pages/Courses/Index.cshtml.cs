using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentCourses.Data;
using StudentCourses.Models;

namespace StudentCourses.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly StudentCourses.Data.StudentCoursesContext _context;

        public IndexModel(StudentCourses.Data.StudentCoursesContext context)
        {
            _context = context;
        }

        public IList<CourseModel> CourseModel { get;set; }

        public async Task OnGetAsync()
        {
            CourseModel = await _context.CourseModel.ToListAsync();
        }
    }
}
