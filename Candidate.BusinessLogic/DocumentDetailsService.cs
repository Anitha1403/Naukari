using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Document details
    /// </summary>
    public class DocumentDetailsService
    {
        /// <summary>
        /// Method that Reads Candidate Document details from console screen
        /// </summary>
        /// <returns></returns>
        public DocumentDetails ReadDocumentDetails()
        {
            DocumentDetails documentDetails = new DocumentDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                // Candidate Document Details
                Console.WriteLine("Provide Candidate Document Details:\n\n");
                //Candidate Aadhar Number
                Console.Write("Enter Aadhar Number:");
                string aadharNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(aadharNumber))
                    documentDetails.AadharNumber = aadharNumber;
                else
                    validations.Append("Candidate Aadhar Number is missing.\n");

                //Candidate PAN Number
                Console.Write("Enter PAN Number:");
                string panNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(panNumber))
                    documentDetails.PANNumber = panNumber;
                else
                    validations.Append("Candidate PAN Number is missing.\n");

                //Candidate Driving Licence
                Console.Write("Enter Driving Licence Number:");
                string drivingLicence = Console.ReadLine();
                if (!string.IsNullOrEmpty(drivingLicence))
                    documentDetails.DrivingLicence = drivingLicence;
                else
                    validations.Append("Candidate Driving Licence number is missing.\n");

                //Candidate Ovter Card Number
                Console.Write("Enter Ovter Card Number:");
                string ovterCardNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(ovterCardNumber))
                    documentDetails.OvterCardNumber = ovterCardNumber;
                else
                    validations.Append("Candidate Ovter Card Number is missing.\n");

                //Candidate Passport Number
                Console.Write("Enter Passport Number:");
                string passportNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(passportNumber))
                    documentDetails.PassportNumber = passportNumber;
                else
                    validations.Append("Candidate Passport Number is missing.\n");

                //Validation error messages
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine("\n\nValidation Errors:\n{0}", validations);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }
            return documentDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Document details to console screen
        /// </summary>
        /// <param name="Details"></param>
        public void PrintContactDetails(DocumentDetails Details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Document Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"Aadhar Number:{Details.AadharNumber}");
                Console.WriteLine($"PAN Number:{Details.PANNumber}");
                Console.WriteLine($"Driving Licence:{Details.DrivingLicence}");
                Console.WriteLine($"Ovter Card Number:{Details.OvterCardNumber}");
                Console.WriteLine($"Passport Number:{Details.PassportNumber}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }

        }
    }
}
