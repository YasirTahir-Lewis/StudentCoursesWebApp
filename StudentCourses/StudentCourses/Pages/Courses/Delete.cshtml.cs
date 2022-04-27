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
    public class DeleteModel : PageModel
    {
        private readonly StudentCourses.Data.StudentCoursesContext _context;

        public DeleteModel(StudentCourses.Data.StudentCoursesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CourseModel CourseModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CourseModel = await _context.CourseModel.FirstOrDefaultAsync(m => m.ID == id);

            if (CourseModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CourseModel = await _context.CourseModel.FindAsync(id);

            if (CourseModel != null)
            {
                _context.CourseModel.Remove(CourseModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
