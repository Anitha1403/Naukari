using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    /// <summary>
    /// Class that holds Candidate Graduation Education Details
    /// </summary>
    public class EducationGraduation
    {
        public string EducationThree { get; set; }
        public string GraduationInstitue { get; set; }
        public string GraduationCourse { get; set; }
        public string GraduationSpecialization { get; set; }
        public string GraduationCourseType { get; set; }
        public string GraduationCourseStartingYear { get; set; }
        public string GraduationCourseEndingYear { get; set; }
        public string GraduationGradingSystem { get; set; }
        public bool PrimaryGraduation { get; set; }
    }
}
