using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Patent details
    /// </summary>
    public class PatentDetailsService
    {
         
        public PatentDetails ReadPatentDetails()
        {
            PatentDetails patentDetails = new PatentDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("\nProvide Patent Details:");
                Console.WriteLine("_________________________\n");
                //PatentTitle
                Console.Write($"Enter Patent title:");
                string patentTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(patentTitle))
                    patentDetails.PatentTitle = patentTitle;
                else
                    validations.Append($"Candidate  Patent  title is missing.\n");

                //PatentURL
                Console.Write($"Enter URL:");
                string patentURL = Console.ReadLine();
                if (!string.IsNullOrEmpty(patentURL))
                    patentDetails.PatentURL = patentURL;
                else
                    validations.Append($"Candidate Patent URL is missing.\n");

                //PatentOffice
                Console.Write($"Enter Patent Office:");
                string patentOffice = Console.ReadLine();
                if (!string.IsNullOrEmpty(patentOffice))
                    patentDetails.PatentOffice = patentOffice;
                else
                    validations.Append($"Candidate Patent office is missing.\n");

                //PatentStatus
                Console.WriteLine("Different values for Patent status:");
                List<string> patentStatusList = new List<string>();
                patentStatusList.Add(Constants.Constants.PATENT_ISUUED);
                patentStatusList.Add(Constants.Constants.PATENT_PENDING);

                Utility.Utility.PrintListValues(patentStatusList);

                Console.Write("\nSelect a value for Patent status(ex.1 for issued):");
                int patentStatusValue = 0;
                bool isPatentStatusHasValue = int.TryParse(Console.ReadLine(), out patentStatusValue);
                string patentStatus = string.Empty;
                if (isPatentStatusHasValue)
                {
                    switch (patentStatusValue)
                    {
                        case (int)Enums.SocialProfile.FaceBook:
                            patentStatus = Constants.Constants.PATENT_ISUUED;
                            break;
                        case (int)Enums.SocialProfile.LinkedIn:
                            patentStatus = Constants.Constants.PATENT_PENDING;
                            break;
                        default:
                            validations.Append("Unknow value for patent status is selected.");
                            break;
                    }
                    patentDetails.PatentStatus = patentStatus;
                }
                else
                {
                    validations.Append("Please select integer value for Patent status(Ex.1 for issued).\n");
                }

                //PatentApplicationNumber
                Console.Write($"Enter Patent Application number:");
                string patentApplicationNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(patentApplicationNumber))
                    patentDetails.PatentApplicationNumber = patentApplicationNumber;
                else
                    validations.Append($"Candidate Patent Application number is missing.\n");

                //PatentIssueDateYear
                Console.Write($"Enter Patent issue date year:");
                string patentIssueDateYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(patentIssueDateYear))
                    patentDetails.PatentIssueDateYear = patentIssueDateYear;
                else
                    validations.Append($"Candidate ResearchPublication year is missing.\n");

                //PatentIssueDateMonth
                Console.Write($"Enter Patent issue date month:");
                string patentIssueDateMonth = Console.ReadLine();
                if (!string.IsNullOrEmpty(patentIssueDateMonth))
                    patentDetails.PatentIssueDateMonth = patentIssueDateMonth;
                else
                    validations.Append($"Candidate ResearchPublication month is missing.\n");

                //PatentDescription
                Console.Write($"Enter Patent Description (minimum 20 characters):");
                string patentDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(patentDescription))
                    if (patentDescription.Length >= 20)
                        patentDetails.PatentDescription = patentDescription;
                    else
                        validations.Append($"Enter Presentation description (minimum 20 characters).\n");
                else
                    validations.Append($"Candidate Presentation description is missing.\n");  

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
            return patentDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Patent details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintPatentDetails(PatentDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Patent Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"Patent title:{details.PatentTitle}");
                Console.WriteLine($"Patent URL:{details.PatentURL}");
                Console.WriteLine($"Patent Office:{details.PatentOffice}");
                Console.WriteLine($"Patent status:{details.PatentStatus}");
                Console.WriteLine($"Patent Application number:{details.PatentApplicationNumber}");
                Console.WriteLine($" Patent issued year:{details.PatentIssueDateYear}");
                Console.WriteLine($"Patent issued month:{details.PatentIssueDateMonth}");
                Console.WriteLine($"Patent description:{details.PatentDescription}");
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
