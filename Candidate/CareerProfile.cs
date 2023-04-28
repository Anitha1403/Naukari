using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    /// <summary>
    /// Class that holds Candidate career profile Details
    /// </summary>
    public class CareerProfile
    {
        public string CurrentIndustry { get; set; }
        public string Department { get; set; }
        public string DesiredJobType { get; set; }
        public string DesiredEmploymentType { get; set; }
        public string PreferredShift { get; set; }
        public string PreferredWorklocation { get; set; }
        public double ExpectedSalary { get; set; }
        public string JobRole { get; set; }
    }
}
