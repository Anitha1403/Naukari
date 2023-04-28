using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate.BusinessLogic;
using Candidate;

namespace CandidatePortal
{
    /// <summary>
    /// Class that holds the Candidate Personal details
    /// </summary>
    public class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\t\t\tCandidate Details:");

                ////Reading Candidate Personal details                
                //PersonalDetailsService personDetailsService  = new PersonalDetailsService();
                //PersonalDetails personalDetails = personDetailsService.ReadPersonalDetails();

                ////Read Candidate Contact details
                //ContactDetailsService contactDetailsService  = new ContactDetailsService();
                //ContactDetails contactDetails = contactDetailsService.ReadContactDetails();

                ////Read Candidate Document details
                //DocumentDetailsService documentDetailsService = new DocumentDetailsService();
                //DocumentDetails documentDetails  = documentDetailsService.ReadDocumentDetails();

                ////Reading Candidate Address details
                //AddressDetailsService addressDetailsService = new AddressDetailsService();
                //AddressDetails addressDetalis  = addressDetailsService.ReadAddressDetails();

                ////Reading Candidate Profile summary details
                //ProfileDetailsService profileDetailsService = new ProfileDetailsService();
                //ProfileDetails profileDetails  = profileDetailsService.ReadProfileDetails();

                ////Reading Candidate Project details
                //ProjectDetailsService projectDetailsService = new ProjectDetailsService();
                //ProjectDetails projectDetails  = projectDetailsService.ReadProjectDetails();

                ////Reading Candidate Career profile
                CareerProfileService careerProfileService = new CareerProfileService();
                CareerProfile careerProfile  = careerProfileService.ReadCareerProfileDetails();





                ////Print Candidate details
                ////Printing Personal details
                //personDetailsService.PrintPersonalDetails(personalDetails);
                ////Printing Contact details
                //contactDetailsService.PrintContactDetails(contactDetails);
                ////Printing Document details
                //documentDetailsService.PrintContactDetails(documentDetails);
                ////Printing Address deails
                //addressDetailsService.PrintAddressDetails(addressDetalis);
                ////Printing Candidate Profile summary details
                //profileDetailsService.PrintProfileDetails(profileDetails);
                ////Printing Candidate Project details
               //projectDetailsService.PrintProjectDetails(projectDetails);
                ////Printing Candidate Career Profile details
                careerProfileService.PrintCareerProfileDetails(careerProfile);
                





                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }


            // Console.ReadLine();
        }
    }
}
