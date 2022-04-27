using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentCourses.Data;
using StudentCourses.Models;

namespace StudentCourses.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly StudentCourses.Data.StudentCoursesContext _context;

        public CreateModel(StudentCourses.Data.StudentCoursesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CourseModel CourseModel { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CourseModel.Add(CourseModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
