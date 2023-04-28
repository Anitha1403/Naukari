using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    //Class holds that Candidate profie details
    public class ProfileDetailsService
    {
        //Read candidate Profile details
        public ProfileDetails ReadProfileDetails()
        {
            ProfileDetails profieDetails = new ProfileDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                //Candidate Profile details
                Console.WriteLine("Provide Candidate Profile Summary Details:\n");
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
                    Console.WriteLine("\nError Validations:\n");

                   Console.WriteLine($"Error Validations:{validations}");
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

        //Print Candidate Profile Details
        public void PrintProfileDetails(ProfileDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Profile Details:\n");
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
