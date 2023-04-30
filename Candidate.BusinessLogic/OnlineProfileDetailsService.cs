using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Online profile details
    /// </summary>
    public class OnlineProfileDetailsService
    {
        /// <summary>
        /// Method that Reads Candidate Online profile details from console screen
        /// </summary>
        /// <returns></returns>
        public OnlineProfileDetails ReadOnlineProfileDetails()
        {
            OnlineProfileDetails onlineProfileDetails = new OnlineProfileDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("Provide Online profile Details:\n");
                Console.WriteLine("Different values for Online social profile:");
                List<string> socialProfiles = new List<string>();
                socialProfiles.Add(Constants.Constants.FACEBOOK);
                socialProfiles.Add(Constants.Constants.LINKED_IN);

                Utility.Utility.PrintListValues(socialProfiles);

                Console.Write("\nSelect a value for social profile(ex.1 for facebook):");
                int socialProfileValue = 0;                
                bool isSocialProfileHasValue=int.TryParse(Console.ReadLine(), out socialProfileValue);
                string socialProfile =string.Empty;
                if (isSocialProfileHasValue)
                {
                    switch (socialProfileValue)
                    {
                        case (int)Enums.SocialProfile.FaceBook:
                            socialProfile = Constants.Constants.FACEBOOK;
                        break;
                        case (int)Enums.SocialProfile.LinkedIn:
                            socialProfile = Constants.Constants.LINKED_IN;
                        break;
                        default:
                            validations.Append("Unknow value for social profile is selected.");
                        break;
                    }
                    onlineProfileDetails.SocialProfile = socialProfile;
                }
                else
                {
                    validations.Append("Please select integer value for socialprofile(Ex.1 for Facebook)\n");
                }

                //SocialProfileURL
                
                Console.Write($"Enter {onlineProfileDetails.SocialProfile} Profile URL:");
                string socialProfileURL = Console.ReadLine();
                if (!string.IsNullOrEmpty(socialProfileURL))
                    onlineProfileDetails.SocialProfileURL = socialProfileURL;
                else
                    validations.Append($"Candidate Social profile URL is missing.\n");
                //SocialProfile Description
                Console.Write($"Enter {onlineProfileDetails.SocialProfile} Profile Description (minimum 20 characters):");
                string socialProfileDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(socialProfileDescription))
                    if (socialProfileDescription.Length >= 20)
                        onlineProfileDetails.SocialProfileDescription = socialProfileDescription;
                    else
                        validations.Append($"Enter social profile Description (minimum 20 characters).\n");
                else
                    validations.Append($"Candidate social profile Description is missing.\n");

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
            return onlineProfileDetails;
        }

        /// <summary>
        /// Method that Prints Candidate Online profile details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintOnlineProfileDetails(OnlineProfileDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Online Profile Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"Social profile:{details.SocialProfile}");
                Console.WriteLine($"Social profile URL:{details.SocialProfileURL}");
                Console.WriteLine($"Social profile description:{details.SocialProfileDescription}");
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
