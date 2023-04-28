using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    /// <summary>
    /// Class that holds Candidate Patent Details
    /// </summary>
    public class PatentDetails
    {
        public string PatentTitle { get; set; }
        public string PatentURL { get; set; }
        public string PatentOffice { get; set; }
        public string PatentStatus { get; set; }
        public string PatentApplicationNumber { get; set; }
        public string PatentIssueDateYear { get; set; }
        public string PatentIssueDateMonth { get; set; }
        public string PatentDescription { get; set; }
    }
}
