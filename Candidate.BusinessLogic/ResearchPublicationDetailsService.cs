using System;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of research publication details
    /// </summary>
    public class ResearchPublicationDetailsService
    {
        /// <summary>
        /// Method that Reads Candidate Research Publication details from console screen
        /// </summary>
        /// <returns></returns>
        public ResearchPublicationDetails ReadResearchPublicationDetails()
        {
            ResearchPublicationDetails researchPublicationDetails = new ResearchPublicationDetails();
            StringBuilder validations = new StringBuilder();
            try
            {

                Console.WriteLine("\nProvide Research Publication Details:");
                Console.WriteLine("_________________________\n");
                //ResearchTitle
                Console.Write($"Enter Research Publication title:");
                string researchPublicationTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(researchPublicationTitle))
                    researchPublicationDetails.ResearchTitle = researchPublicationTitle;
                else
                    validations.Append($"Candidate  ResearchPublicationTitle is missing.\n");

                //ResearchURL
                Console.Write($"Enter URL:");
                string researchPublicationURL = Console.ReadLine();
                if (!string.IsNullOrEmpty(researchPublicationURL))
                    researchPublicationDetails.ResearchURL = researchPublicationURL;
                else
                    validations.Append($"Candidate Research publication URL is missing.\n");
                
                //ResearchPublicationYear
                Console.Write($"Enter Research publicaion year:");
                string researchPublicationYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(researchPublicationYear))
                    researchPublicationDetails.ResearchPublicationYear = researchPublicationYear;
                else
                    validations.Append($"Candidate ResearchPublication year is missing.\n");
              
                //ResearchPublicationMonth
                Console.Write($"Enter ResearchPublication month:");
                string researchPublicationMonth = Console.ReadLine();
                if (!string.IsNullOrEmpty(researchPublicationMonth))
                    researchPublicationDetails.ResearchPublicationMonth = researchPublicationMonth;
                else
                    validations.Append($"Candidate ResearchPublication month is missing.\n");
                
                //Description
                Console.Write($"Enter ResearchPublication  Description (minimum 20 characters):");
                string researchDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(researchDescription))
                    if (researchDescription.Length >= 20)
                        researchPublicationDetails.ResearchDescription = researchDescription;
                    else
                        validations.Append($"Enter Research publication description (minimum 20 characters).\n");
                else
                    validations.Append($"Candidate Research publication description is missing.\n");


                //Validation error messages
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine("\n\nValidation Errors:\n{0}", validations);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception messages:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"Exception StackTrace:{ex.StackTrace}");
            }
            return researchPublicationDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Research Publication details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintResearchPublicationDetails(ResearchPublicationDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Research Publication Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"Research Pubication Title:{details.ResearchTitle}");
                Console.WriteLine($"URL:{details.ResearchURL}");
                Console.WriteLine($"Research Pubication Year:{details.ResearchPublicationYear}");
                Console.WriteLine($"Research Pubication Month:{details.ResearchPublicationMonth}");
                Console.WriteLine($"Description:{details.ResearchDescription}");
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
