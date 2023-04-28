using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    /// <summary>
    /// Class that holds Candidate Personal Details
    /// </summary>
    public class PersonalDetails
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string CandidateType { get; set; }
        public string MaritalStatus { get; set; }
        public string DateofBirth { get; set; }
        public string Category { get; set; }
        public bool DifferentlyAbled { get; set; }
        public bool CareerBreak { get; set; }
        public string WorkPermitUSA { get; set; }
        public string WorkPermitOtherCountries { get; set; }
        public string WorkStatus { get; set; }
        public string NoticePeriods { get; set; }
    }
}
