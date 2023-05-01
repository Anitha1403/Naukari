using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Graduation details
    /// </summary>
    public class EducationGraduationService
    {
        /// <summary>
        /// Method that Reads Candidate Graduation education details from console screen
        /// </summary>
        /// <returns></returns>
        public EducationGraduation ReadGraduationEducationDetails()
        {
            EducationGraduation educationGraduationDetails = new EducationGraduation();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("\nCandidate graduation Details.");
                Console.WriteLine("_______________________________\n");
                //graduation institute name
                Console.Write("Enter graduation Institute name:");
                string graduationInstitue = Console.ReadLine();
                if (!string.IsNullOrEmpty(graduationInstitue))
                    educationGraduationDetails.GraduationInstitue = graduationInstitue;
                else
                    validations.Append("Graduation Institute value is missing.\n");
                //GraduationCourse
                Console.WriteLine("Different values for graduation Course:");
                List<string> graduationCourseList = new List<string>();
                graduationCourseList.Add(Constants.Constants.GRADUATION_BSC);       
                graduationCourseList.Add(Constants.Constants.GRADUATION_BCOM);  
                graduationCourseList.Add(Constants.Constants.GRADUATION_BA);    
                graduationCourseList.Add(Constants.Constants.GRADUATION_BTECH); 

                Utility.Utility.PrintListValues(graduationCourseList);

                Console.Write("Select a integer value for graduation Course(ex.1 for B.SC):");
                string graduationCourse = Console.ReadLine();
                if (!string.IsNullOrEmpty(graduationCourse))
                {
                    int graduationCourseValue = 0;
                    bool isgraduationCourseHasValue = int.TryParse(graduationCourse, out graduationCourseValue);
                    if (isgraduationCourseHasValue)
                    {
                        switch (graduationCourseValue)
                        {                       

                            case (int)Enums.GraduationCourse.BSC:
                                graduationCourse = Constants.Constants.GRADUATION_BSC;
                                break;
                            case (int)Enums.GraduationCourse.BCOM:
                                graduationCourse = Constants.Constants.GRADUATION_BCOM;
                                break;
                            case (int)Enums.GraduationCourse.BA:
                                graduationCourse = Constants.Constants.GRADUATION_BA;
                                break;
                            case (int)Enums.GraduationCourse.Btech:
                                graduationCourse = Constants.Constants.GRADUATION_BTECH;
                                break;
                            default:
                                validations.Append("Unknown value selected for graduation Course.\n");
                                break;
                        }
                        educationGraduationDetails.GraduationCourse = graduationCourse;
                    }
                    else
                        validations.Append("Provide a integer value for Graduation Course(ex.1 for M.Tech).\n");
                }
                else
                    validations.Append("Graduation Course value is missing.\n");

                //graduationSpecialization
                Console.WriteLine("Different values for Graduation Specialization:");
                List<string> graduationSpecializationList = new List<string>();
                graduationSpecializationList.Add(Constants.Constants.GRADUATION_COMPUTERS);
                graduationSpecializationList.Add(Constants.Constants.GRADUATION_CIVIL);
                graduationSpecializationList.Add(Constants.Constants.GRADUATION_CHEMICAL);
                graduationSpecializationList.Add(Constants.Constants.GRADUATION_COMMUNICATION);

                Utility.Utility.PrintListValues(graduationSpecializationList);
                Console.Write("Select a integer value for graduation Specialization(ex.1 for Computers):");
                string graduationSpecialization = Console.ReadLine();
                if (!string.IsNullOrEmpty(graduationSpecialization))
                {
                    int graduationSpecializationValue = 0;
                    bool isgraduationSpecializationHasValue = int.TryParse(graduationSpecialization, out graduationSpecializationValue);
                    if (isgraduationSpecializationHasValue)
                    {
                        switch (graduationSpecializationValue)
                        {
                            case (int)Enums.GraduationSpecialization.Computers:
                                graduationSpecialization = Constants.Constants.GRADUATION_COMPUTERS;
                                break;
                            case (int)Enums.GraduationSpecialization.Civil:
                                graduationSpecialization = Constants.Constants.GRADUATION_CIVIL;
                                break;
                            case (int)Enums.GraduationSpecialization.Chemical:
                                graduationSpecialization = Constants.Constants.GRADUATION_CHEMICAL;
                                break;
                            case (int)Enums.GraduationSpecialization.Communication:
                                graduationSpecialization = Constants.Constants.GRADUATION_COMMUNICATION;
                                break;
                            default:
                                validations.Append("Unknown value selected for Graduation Specialization.\n");
                                break;
                        }
                        educationGraduationDetails.GraduationSpecialization = graduationSpecialization;
                    }
                    else
                        validations.Append("Provide a integer value for Graduation Specialization(ex.1 for Computers).\n");
                }
                else
                    validations.Append("Graduation Specialization value is missing.\n");


                //graduationCourseType
                Console.WriteLine("Different values for graduation Course:");
                List<string> graduationCourseTypeList = new List<string>();
                graduationCourseTypeList.Add(Constants.Constants.GRADUATION_FULLTIME);
                graduationCourseTypeList.Add(Constants.Constants.GRADUATION_PARTTIME);
                graduationCourseTypeList.Add(Constants.Constants.GRADUATION_DISTANCE);


                Utility.Utility.PrintListValues(graduationCourseTypeList);

                Console.Write("Select a integer value for graduation Course Type (ex.1 for Full time):");
                string graduationCourseType = Console.ReadLine();
                if (!string.IsNullOrEmpty(graduationCourseType))
                {
                    int graduationCourseTypeValue = 0;
                    bool isgraduationCourseTypeHasValue = int.TryParse(graduationCourseType, out graduationCourseTypeValue);
                    if (isgraduationCourseTypeHasValue)
                    {
                        switch (graduationCourseTypeValue)
                        {
                            case (int)Enums.GraduationCourseType.FullTime:
                                graduationCourseType = Constants.Constants.GRADUATION_FULLTIME;
                                break;                                     
                            case (int)Enums.GraduationCourseType.PartTime: 
                                graduationCourseType = Constants.Constants.GRADUATION_PARTTIME;
                                break;                                     
                            case (int)Enums.GraduationCourseType.Distance: 
                                graduationCourseType = Constants.Constants.GRADUATION_DISTANCE;
                                break;
                            default:
                                validations.Append("Unknown value selected for Graduation Course Type.\n");
                                break;
                        }
                        educationGraduationDetails.GraduationCourseType = graduationCourseType;
                    }
                    else
                        validations.Append("Provide a integer value for Graduation Course Type(ex.1 for Full time).\n");
                }
                else
                    validations.Append("Graduation Course Type value is missing.\n");

                //graduationCourseStartingYear
                Console.Write("Enter graduation Course Starting Year:");
                string graduationCourseStartingYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(graduationCourseStartingYear))
                    educationGraduationDetails.GraduationCourseStartingYear = graduationCourseStartingYear;
                else
                    validations.Append("Graduation Course Starting Year value is missing.\n");

                //graduationCourseCourseEndingYear
                Console.Write("Enter graduation Course Ending Year:");
                string graduationCourseEndingYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(graduationCourseEndingYear))
                    educationGraduationDetails.GraduationCourseEndingYear = graduationCourseEndingYear;
                else
                    validations.Append("Graduation Course Ending Year value is missing.\n");

                //graduationGradingSystem
                Console.WriteLine("Different values for graduation Grading System Type:");
                List<string> graduationGradingSystemList = new List<string>();
                graduationGradingSystemList.Add(Constants.Constants.SCALE10_GRADUATION_GRADING_SYSTEM);
                graduationGradingSystemList.Add(Constants.Constants.SCALE4_GRADUATION_GRADING_SYSTEM);
                graduationGradingSystemList.Add(Constants.Constants.PASS_GRADUATION_GRADING_SYSTEM);

                Utility.Utility.PrintListValues(graduationGradingSystemList);

                Console.Write("Select a integer value for graduation Grading System  Type (ex.1 for Scale 10 Grading system):");
                string graduationGradingSystem = Console.ReadLine();
                if (!string.IsNullOrEmpty(graduationGradingSystem))
                {
                    int graduationGradingSystemValue = 0;
                    bool isgraduationGradingSystemHasValue = int.TryParse(graduationGradingSystem, out graduationGradingSystemValue);
                    if (isgraduationGradingSystemHasValue)
                    {
                        switch (graduationGradingSystemValue)
                        {
                            case (int)Enums.GraduationGradingSystem.Scale10:
                                graduationGradingSystem = Constants.Constants.SCALE10_GRADUATION_GRADING_SYSTEM;
                                break;
                            case (int)Enums.GraduationGradingSystem.Scale4:
                                graduationGradingSystem = Constants.Constants.SCALE4_GRADUATION_GRADING_SYSTEM;
                                break;
                            case (int)Enums.GraduationGradingSystem.CourseRequiresPass:
                                graduationGradingSystem = Constants.Constants.PASS_GRADUATION_GRADING_SYSTEM;
                                break;
                            default:
                                validations.Append("Unknown value selected for graduation Grading system Type.\n");
                                break;
                        }
                        educationGraduationDetails.GraduationGradingSystem = graduationGradingSystem;
                    }
                    else
                        validations.Append("Provide a integer value for graduation Grading system Type(ex.1 for scale 10 grading system).\n");
                }
                else
                    validations.Append("graduation Grading system Type value is missing.\n");

                //PrimaryGraduation
                Console.Write("Is this Primary Graduation?(Enter True/False):");
                string primaryGraduationValue = Console.ReadLine();
                if (!string.IsNullOrEmpty(primaryGraduationValue))
                {
                    if (primaryGraduationValue.ToLower() == "true" || primaryGraduationValue.ToLower() == "false")
                    {
                        bool primaryGraduation = Convert.ToBoolean(primaryGraduationValue);
                        educationGraduationDetails.PrimaryGraduation = primaryGraduation;
                    }
                    else
                        validations.Append("Provide a value for PrimaryGraduation(ex.true for Primary education).\n");
                }
                else
                    validations.Append("Primary Graduation value is missing.");

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
            return educationGraduationDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Graduation education details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintGraduationEducationDetails(EducationGraduation details)
        {
            try
            {
                Console.WriteLine("\nCandidate Graduation Education Details:");
                Console.WriteLine("________________________________________\n");
                Console.WriteLine($"Institute Name:{details.GraduationInstitue}");
                Console.WriteLine($"Course:{details.GraduationCourse}"); 
                Console.WriteLine($"Specialization:{details.GraduationSpecialization}");      
                Console.WriteLine($"Course Type:{details.GraduationCourseType}");     
                Console.WriteLine($"Course starting year:{details.GraduationCourseStartingYear}"); 
                Console.WriteLine($"Course ending year:{details.GraduationCourseEndingYear}"); 
                Console.WriteLine($"Grading system:{details.GraduationGradingSystem}");
                if (details.PrimaryGraduation)
                    Console.WriteLine($"Primary Graduation:{Constants.Constants.PRIMARY_GRADUATION}");
                else
                    Console.WriteLine($"Primary Graduation:{Constants.Constants.NOT_PRIMARY_GRADUATION}");
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
