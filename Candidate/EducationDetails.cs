using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    /// <summary>
    /// Class that holds Candidate All Education Details
    /// </summary>
    public class EducationDetails
    {
        public EducationSSC EducationSSC { get; set; }
        public EducationTwelfth EducationTwelfth { get; set; }
        public EducationGraduation EducationGraduation { get; set; }
        public EducationPG EducationPG { get; set; }
        public EducationDoctorate EducationDoctorate { get; set; }
    }
}
