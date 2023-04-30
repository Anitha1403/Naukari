using System;

namespace Candidate.BusinessLogic
{ 
    /// <summary>
    /// Class holds services of Education details
    /// </summary>
    public class EducationDetailsService
    {
        /// <summary>
        /// Method that Reads Candidate Education details from console screen
        /// </summary>
        /// <returns></returns>
        public EducationDetails ReadEducationDetails()
        {
            EducationDetails educationDetails = new EducationDetails();
            try
            {
                EducationSSCService educationSSCDetailsService = new EducationSSCService();
                educationDetails.EducationSSC = educationSSCDetailsService.ReadSSCEducationDetails();

                EducationTwelfthService educationTwelfthDetailsService = new EducationTwelfthService();
                educationDetails.EducationTwelfth = educationTwelfthDetailsService.ReadTwelfthEducationDetails();

                EducationGraduationService educationGraduationDetailsService = new EducationGraduationService();
                educationDetails.EducationGraduation = educationGraduationDetailsService.ReadGraduationEducationDetails();

                EducationPGService educationPGDetailsService = new EducationPGService();
                educationDetails.EducationPG = educationPGDetailsService.ReadPGEducationDetails();

                EducationDoctorateService educationDoctorateDetailsService = new EducationDoctorateService();
                educationDetails.EducationDoctorate = educationDoctorateDetailsService.ReadDoctorateEducationDetails();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception messages:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"Exception StackTrace:{ex.StackTrace}");
            }
            return educationDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Education details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintEducationDetails(EducationDetails details)
        {
            try
            {
                EducationSSCService educationSSCDetailsService = new EducationSSCService();
                educationSSCDetailsService.PrintSSCEducationDetails(details.EducationSSC);

                EducationTwelfthService educationTwelfthDetailsService = new EducationTwelfthService();
                educationTwelfthDetailsService.PrintTwelfthEducationDetails(details.EducationTwelfth);

                EducationGraduationService educationGraduationDetailsService = new EducationGraduationService();
                educationGraduationDetailsService.PrintGraduationEducationDetails(details.EducationGraduation);


                EducationPGService educationPGDetailsService = new EducationPGService();
                educationPGDetailsService.PrintPGEducationDetails(details.EducationPG);

                EducationDoctorateService educationDoctorateDetailsService = new EducationDoctorateService();
                educationDoctorateDetailsService.PrintDoctorateEducationDetails(details.EducationDoctorate);
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
