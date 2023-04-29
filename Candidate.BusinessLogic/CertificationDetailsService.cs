using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class CertificationDetailsService
    {
        public CertificationDetails ReadCertificationDetails()
        {
            CertificationDetails certificationDetails = new CertificationDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("Provide Certification Details:\n");
                //CertificationName
                Console.Write($"Enter Certification name:");
                string certificationName = Console.ReadLine();
                if (!string.IsNullOrEmpty(certificationName))
                    certificationDetails.CertificationName = certificationName;
                else
                    validations.Append($"Certificaion name is missing.\n");


                //CertificationCompletionID
                Console.Write($"Enter Certification competion ID:");
                string completionID = Console.ReadLine();
                if (!string.IsNullOrEmpty(completionID))
                    certificationDetails.CertificationCompletionID = completionID;
                else
                    validations.Append($"Certification competion ID is missing.\n");


                //CertificationURL
                Console.Write($"Enter certification URL:");
                string certificationURL = Console.ReadLine();
                if (!string.IsNullOrEmpty(certificationURL))
                    certificationDetails.CertificationURL = certificationURL;
                else
                    validations.Append($"Certification URL is missing.\n");

               
                //CertificationValidityFromYear
                Console.Write($"Enter Certification validity from year:");
                string validityFromYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(validityFromYear))
                    certificationDetails.CertificationValidityFromYear = validityFromYear;
                else
                    validations.Append($"Certification validity from year is missing.\n");
                
                //CertificationValidityFromMonth
                Console.Write($"Enter Certification validity from month:");
                string validityFromMonth = Console.ReadLine();
                if (!string.IsNullOrEmpty(validityFromMonth))
                    certificationDetails.CertificationValidityFromMonth = validityFromMonth;
                else
                    validations.Append($"Certification validity from month is missing.\n");


                //CertificationValidityToYear
                Console.Write($"Enter Certification validity end year:");
                string validityToYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(validityToYear))
                    certificationDetails.CertificationValidityEndYear = validityToYear;
                else
                    validations.Append($"Certification validity end year is missing.\n");

                //CertificationValidityFromMonth
                Console.Write($"Enter Certification validity end month:");
                string validityToMonth = Console.ReadLine();
                if (!string.IsNullOrEmpty(validityToMonth))
                    certificationDetails.CertificationValidityEndMonth = validityToMonth;
                else
                    validations.Append($"Certification validity end month is missing.\n");

                //CertificationExpires
                Console.Write("Is Certification expire?(Enter True/False):");
                string certificationExpires = Console.ReadLine();
                if (!string.IsNullOrEmpty(certificationExpires))
                {
                    if (certificationExpires.ToLower() == "true" || certificationExpires.ToLower() == "false")
                    {
                        bool certificationExpiresValue = Convert.ToBoolean(certificationExpires);
                        certificationDetails.CertificationExpires = certificationExpiresValue;
                    }
                    else
                        validations.Append("Provide a value for Certification expires(ex.true/false).\n");
                }
                else
                    validations.Append("Certification expire value is missing.");

                //Validation error messages
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine("\n\nValidation Errors:{0}", validations);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception messages:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"Exception StackTrace:{ex.StackTrace}");
            }
            return certificationDetails;
        }

        public void PrintCerificationDetails(CertificationDetails details)
        {
            try
            {

                Console.WriteLine();
                Console.WriteLine("Candidate Certification Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"Certification name:{details.CertificationName}");
                Console.WriteLine($"Certification completion ID:{details.CertificationCompletionID}");
                Console.WriteLine($"Certification URL:{details.CertificationURL}");
                Console.WriteLine($"Certification validity From Year:{details.CertificationValidityFromYear}");
                Console.WriteLine($"Certification validity  From Month:{details.CertificationValidityFromMonth}");
                Console.WriteLine($"Certification validity  end Year:{details.CertificationValidityEndYear}");
                Console.WriteLine($"Certification validity end Month:{details.CertificationValidityEndMonth}");
                if (details.CertificationExpires == true)
                    Console.WriteLine($"Certification expires:{Constants.Constants.CERTIFICATION_EXPIRES}");
                else
                    Console.WriteLine($"Certification expires:{Constants.Constants.CERTIFICATION_NOT_EXPIRES}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception messages:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"Exception StackTrace:{ex.StackTrace}");
            }
        }
    }
}
