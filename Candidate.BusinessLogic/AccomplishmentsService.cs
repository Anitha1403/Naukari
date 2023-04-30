using System;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// class holds services of Accompishments
    /// </summary>
    public class AccomplishmentsService
    {
        /// <summary>
        /// Method that Reads Candidate Accomplishments details from console screen
        /// </summary>
        /// <returns></returns>
        public Accomplishments ReadAccomplishments()
        {
            Accomplishments accomplishments = new Accomplishments();
            try
            {
                OnlineProfileDetailsService onlineProfileDetailsService = new OnlineProfileDetailsService();
                accomplishments.OnlineProfileDetails = onlineProfileDetailsService.ReadOnlineProfileDetails();

                WorkSampleDetailsService workSampleDetailsService = new WorkSampleDetailsService();
                accomplishments.WorkSampleDetails = workSampleDetailsService.ReadWorkSampleDetails();

                ResearchPublicationDetailsService researchPublicationDetailsService =
                    new ResearchPublicationDetailsService();
                accomplishments.ResearchPublicationDetails = researchPublicationDetailsService.ReadResearchPublicationDetails();

                PresentationDetailsService presentationDetailsService = new PresentationDetailsService();
                accomplishments.PresentationDetails = presentationDetailsService.ReadPresentationDetails();

                PatentDetailsService patentDetailsService = new PatentDetailsService();
                accomplishments.PatentDetails = patentDetailsService.ReadPatentDetails();

                CertificationDetailsService certificationDetailsService = new CertificationDetailsService();
                accomplishments.CertificationDetails = certificationDetailsService.ReadCertificationDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception messages:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"Exception StackTrace:{ex.StackTrace}");
            }
            return accomplishments;
        }
        /// <summary>
        ///Method that Prints Candidate Accomplishments details to console screen 
        /// </summary>
        /// <param name="details"></param>
        public void PrintAccomplishments(Accomplishments details)
        {
            try 
            {
                OnlineProfileDetailsService onlineProfileDetailsService = new OnlineProfileDetailsService();
                onlineProfileDetailsService.PrintOnlineProfileDetails(details.OnlineProfileDetails);

                WorkSampleDetailsService workSampleDetailsService = new WorkSampleDetailsService();
                workSampleDetailsService.PrintWorkSampleDetails(details.WorkSampleDetails);

                ResearchPublicationDetailsService researchPublicationDetailsService =
                    new ResearchPublicationDetailsService();
                researchPublicationDetailsService.PrintResearchPublicationDetails(details.ResearchPublicationDetails);

                PresentationDetailsService presentationDetailsService = new PresentationDetailsService();
                presentationDetailsService.PrintPresentationDetails(details.PresentationDetails);

                PatentDetailsService patentDetailsService = new PatentDetailsService();
                patentDetailsService.PrintPatentDetails(details.PatentDetails);

                CertificationDetailsService certificationDetailsService = new CertificationDetailsService();
                certificationDetailsService.PrintCerificationDetails(details.CertificationDetails);
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
