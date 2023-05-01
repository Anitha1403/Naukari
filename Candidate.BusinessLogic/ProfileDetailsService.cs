using System;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds that service of  Profile details
    /// </summary>
    public class ProfileDetailsService
    {
        /// <summary>
        ///  Method that reads Candidate Profile details from console screen
        /// </summary>
        /// <returns></returns>       
        public ProfileDetails ReadProfileDetails()
        {
            ProfileDetails profieDetails = new ProfileDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                //Candidate Profile details
                Console.WriteLine("\nProvide Candidate Profile Summary Details:");
                Console.WriteLine("_________________________\n");
                //Profile summary
                Console.Write("Enter Profile summary (minimum 15 characters):");
                string profileSummary = Console.ReadLine();
                if (!string.IsNullOrEmpty(profileSummary))
                    if (profileSummary.Length >= 15)
                        profieDetails.ProfileSummary = profileSummary;
                    else
                        validations.Append("Enter Profile summary (minimum 15 characters).\n");
                else
                    validations.Append("Candidate Profile summary is missing.\n");
                //Resume HeadLine
                Console.Write("Enter Resume headline:");
                string resumeHeadLine=Console.ReadLine();
                if (!string.IsNullOrEmpty(resumeHeadLine))
                    profieDetails.ResumeHeadline = resumeHeadLine;
                else
                    validations.Append("Candidate Resume Headline is missing.\n");

                //Error Validations
                if (!string.IsNullOrEmpty(validations.ToString()))
                {                   
                   Console.WriteLine($"\n\nError Validations:\n{validations}");
                }                                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepion message:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"Exception Stack free:{ex.StackTrace}");
            }
            return profieDetails;
        }

        /// <summary>
        ///  Method that Prints Candidate Profile details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintProfileDetails(ProfileDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Profile Details:");
                Console.WriteLine("__________________________\n");
                Console.WriteLine($"Profile summary:{details.ProfileSummary}");
                Console.WriteLine($"Reasume HeadLine:{details.ResumeHeadline}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception Mesage: {ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"Exception Stack Trace: {ex.StackTrace}");
            }

        }

    }
}
