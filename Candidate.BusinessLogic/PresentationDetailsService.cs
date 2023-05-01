using System;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Presentation Details
    /// </summary>
    public class PresentationDetailsService
    {
        /// <summary>
        ///  Method that reads Candidate Presentation details from console screen
        /// </summary>
        /// <returns></returns>
        public PresentationDetails ReadPresentationDetails()
        {
            PresentationDetails presentationDetails = new PresentationDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("\nProvide Presentation Details:");
                Console.WriteLine("____________________________\n");
                //PresentationTitle
                Console.Write("Enter Presentation title:");
                string presentationTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(presentationTitle))
                    presentationDetails.PresentationTitle = presentationTitle;
                else
                    validations.Append("Candidate  Presentation  title is missing.\n");

                //PresentationURL
                Console.Write($"Enter URL:");
                string presentationURL = Console.ReadLine();
                if (!string.IsNullOrEmpty(presentationURL))
                    presentationDetails.PresentationURL = presentationURL;
                else
                    validations.Append("Candidate Presentation URL is missing.\n");
                
                //PresentationDescription
                Console.Write("Enter Presentation  Description (minimum 20 characters):");
                string presentationDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(presentationDescription))
                    if (presentationDescription.Length >= 20)
                        presentationDetails.PresentationDescription = presentationDescription;
                    else
                        validations.Append("Enter Presentation description (minimum 20 characters).\n");
                else
                    validations.Append("Candidate Presentation description is missing.\n");               


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
            return presentationDetails;
        }
        /// <summary>
        ///  Method that prints Candidate Presentation details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintPresentationDetails(PresentationDetails details)
        {
            try
            {

                Console.WriteLine();
                Console.WriteLine("Candidate Presentation Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"Presentation Title:{details.PresentationTitle}");
                Console.WriteLine($"URL:{details.PresentationURL}");
                Console.WriteLine($"Description:{details.PresentationDescription}");
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
