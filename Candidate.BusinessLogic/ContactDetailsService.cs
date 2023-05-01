using System;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Contact details
    /// </summary>
    public class ContactDetailsService
    {
        /// <summary>
        /// Method that Reads Candidate Contact details from console screen
        /// </summary>
        /// <returns></returns>
        public ContactDetails ReadContactDetails()
        {
            ContactDetails contactDetails = new ContactDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                // Candidate Contact Details
                Console.WriteLine("\nProvide Candidate Contact Details:");
                Console.WriteLine("_________________________\n");
                //Candidate Primary Phone Number
                Console.Write("Enter Primary Phone Number:");
                string primaryPhoneNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(primaryPhoneNumber))
                    contactDetails.PrimaryPhoneNumber = primaryPhoneNumber;
                else
                    validations.Append("Candidate Primary phone number is missing.\n");

                //Candidate Secondary Phone number
                Console.Write("Enter Secondary Phone Number:");
                string secondaryPhoneNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(secondaryPhoneNumber))
                    contactDetails.SecondaryPhoneNumber = secondaryPhoneNumber;
                else
                    validations.Append("Candidate Secondary phone number is missing.\n");

                //Candidate Primary Email address
                Console.Write("Enter Primary Email Address:");
                string primaryMailID = Console.ReadLine();
                if (!string.IsNullOrEmpty(primaryMailID))
                    contactDetails.PrimaryEmailAddress = primaryMailID;
                else
                    validations.Append("Candidate Primary Email address is missing.\n");

                //Candidate Secondary Email address
                Console.Write("Enter Secondary Email Address:");
                string secondaryMailID = Console.ReadLine();
                if (!string.IsNullOrEmpty(secondaryMailID))
                    contactDetails.SecondaryEmailAddress = secondaryMailID;
                else
                    validations.Append("Candidate Secondary Email address is missing.\n");

                //Validation error messages
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine("\nValidation Errors:\n{0}", validations);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }
            return contactDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Contact details to console screen
        /// </summary>
        /// <param name="Details"></param>
        public void PrintContactDetails(ContactDetails Details)
        {
            try
            {               
                Console.WriteLine("\nCandidate Contact Details:");
                Console.WriteLine("______________________________\n");
                Console.WriteLine($"Primary Phone Number:{Details.PrimaryPhoneNumber}");
                Console.WriteLine($"Secondary Phone Number:{Details.SecondaryPhoneNumber}");
                Console.WriteLine($"Primary Email Address:{Details.PrimaryEmailAddress}");
                Console.WriteLine($"Secondary Email Address:{Details.SecondaryEmailAddress}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }
        }
    }
}
