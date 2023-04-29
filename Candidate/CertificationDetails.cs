using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    /// <summary>
    /// Class that holds Candidate Certification Details
    /// </summary>
    public class CertificationDetails
    {
        public string CertificationName { get; set; }
        public string CertificationCompletionID { get; set; }
        public string CertificationURL { get; set; }
        public string CertificationValidityFromYear { get; set; }
        public string CertificationValidityFromMonth { get; set; }
        public string CertificationValidityEndYear { get; set; }
        public string CertificationValidityEndMonth { get; set; }
        public bool CertificationExpires { get; set; }
    }
}
