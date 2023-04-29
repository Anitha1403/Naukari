using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class WorkSampleDetailsService
    {
        public WorkSampleDetails ReadWorkSampleDetails()
        {
            WorkSampleDetails workSampleDetails = new WorkSampleDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                //Work Title
                           
                Console.Write($"Enter Work sample title:");
                string workitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(workitle))
                    workSampleDetails.WorkTitle = workitle;
                else
                    validations.Append($"Candidate  Work sample title is missing.\n");

                //URL
                Console.Write($"Enter {workSampleDetails.WorkTitle} URL:");
                string workSampleURL = Console.ReadLine();
                if (!string.IsNullOrEmpty(workSampleURL))
                    workSampleDetails.WorkTitleURL = workSampleURL;
                else
                    validations.Append($"Candidate Work sample URL is missing.\n");

                //Duration From Year
                Console.Write($"Enter {workSampleDetails.WorkTitle} duration from year:");
                string durationFromYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(durationFromYear))
                    workSampleDetails.WorkTitleFromYear = durationFromYear;
                else
                    validations.Append($"Candidate Work sample duration from year is missing.\n");

                //Duration From Month
                Console.Write($"Enter {workSampleDetails.WorkTitle} duration from month:");
                string durationFromMonth = Console.ReadLine();
                if (!string.IsNullOrEmpty(durationFromMonth))
                    workSampleDetails.WorkTitleFromMonth = durationFromMonth;
                else
                    validations.Append($"Candidate Work sample duration from month is missing.\n");

                //Duration To Year
                Console.Write($"Enter {workSampleDetails.WorkTitle} duration to year:");
                string durationToYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(durationToYear))
                    workSampleDetails.WorkTitleToYear = durationToYear;
                else
                    validations.Append($"Candidate Work sample duration to year is missing.\n");

                //Duration To Month
                Console.Write($"Enter {workSampleDetails.WorkTitle} duration to month:");
                string durationToMonth = Console.ReadLine();
                if (!string.IsNullOrEmpty(durationToMonth))
                    workSampleDetails.WorkTitleToMonth = durationToMonth;
                else
                    validations.Append($"Candidate Work sample duration to month is missing.\n");

                //Currently Working
                Console.Write("\nAre you Currently Working on this work sampe?(Enter True/False):");
                string currentlyWorking = Console.ReadLine();
                if (!string.IsNullOrEmpty(currentlyWorking))
                {
                    if (currentlyWorking.ToLower() == "true" || currentlyWorking.ToLower() == "false")
                    {
                        bool currentlyWorkingBoolValue = Convert.ToBoolean(currentlyWorking);
                        workSampleDetails.WorkTitleCurrentlyWorking = currentlyWorkingBoolValue;
                    }
                    else
                        validations.Append("Provide a value for currently working(ex.true/false).\n");
                }
                else
                    validations.Append("Currently working value is missing.");

                //Description
                Console.Write($"Enter {workSampleDetails.WorkTitle} Description (minimum 20 characters):");
                string workSampleDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(workSampleDescription))
                    if (workSampleDescription.Length >= 20)
                        workSampleDetails.WorkTitleDescription = workSampleDescription;
                    else
                        validations.Append($"Enter work sample description (minimum 20 characters).\n");
                else
                    validations.Append($"Candidate work sample description is missing.\n");

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
            return workSampleDetails;
        }

        public void PrintWorkSampleDetails(WorkSampleDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Work sample Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"Work Title:{details.WorkTitle}");
                Console.WriteLine($"URL:{details.WorkTitleURL}");
                Console.WriteLine($"WorkTitle From Year:{details.WorkTitleFromYear}");
                Console.WriteLine($"WorkTitle From Month:{details.WorkTitleFromMonth}");
                Console.WriteLine($"WorkTitle To Year:{details.WorkTitleToYear}");
                Console.WriteLine($"WorkTitle To Month:{details.WorkTitleToMonth}");
                if (details.WorkTitleCurrentlyWorking == true)
                    Console.WriteLine($"Currently working:{Constants.Constants.CURRENTLY_WORKING}");
                else
                    Console.WriteLine($"Currently working:{Constants.Constants.CURRENTLY_NOT_WORKING}");
                Console.WriteLine($"Description:{details.WorkTitleDescription}");
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
