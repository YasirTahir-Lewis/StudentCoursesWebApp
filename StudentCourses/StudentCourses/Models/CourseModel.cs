using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourses.Models
{
    public class CourseModel
    {
        public int ID { get; set; }

        [Display(Name="University Name")]
        [StringLength(100, MinimumLength =5)]
        public string UniversityName { get; set; }

        [Display(Name = "Course Name")]
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string CourseName { get; set; }

        [Display(Name = "Course Code")]
        [Required]
        public string CourseCode { get; set; }

        [Display(Name = "Professor Name")]
        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string ProfessorName { get; set; }

        [Display(Name = "Course Rating")]
        [Required]
        [Range(1, 10)]
        public int CourseRating { get; set; }

        [Display(Name = "Course Description")]
        [StringLength(200, MinimumLength = 10)]
        public string CourseDescription { get; set; }
    }
}
