using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Doctorate details
    /// </summary>
    public class EducationDoctorateService
    {
        /// <summary>
        /// Method that Reads Candidate Doctorate education details from console screen
        /// </summary>
        /// <returns></returns>
        public EducationDoctorate ReadDoctorateEducationDetails()
        {
            EducationDoctorate educationDoctorateDetails = new EducationDoctorate();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("\nCandidate Doctorate Details.");
                Console.WriteLine("_______________________________\n");
                //Doctorate institute name
                Console.Write("Enter Doctorate Institute name:");
                string doctorateInstitue = Console.ReadLine();
                if (!string.IsNullOrEmpty(doctorateInstitue))
                    educationDoctorateDetails.DoctorateInstitue = doctorateInstitue;
                else
                    validations.Append("Doctorate Institute value is missing.\n");
                // Doctorate Course
                Console.WriteLine("Different values for Doctorate Course:");
                List<string> doctorateCourseList = new List<string>();
                doctorateCourseList.Add(Constants.Constants.DOCTORATE_PHD);
                doctorateCourseList.Add(Constants.Constants.DOCTORATE_MPHILL);

                Utility.Utility.PrintListValues(doctorateCourseList);

                Console.Write("Select a integer value for Doctorate Course(ex.1 for Phd):");
                string doctorateCourse = Console.ReadLine();
                if (!string.IsNullOrEmpty(doctorateCourse))
                {
                    int doctorateCourseValue = 0;
                    bool isDoctorateCourseHasValue = int.TryParse(doctorateCourse, out doctorateCourseValue);
                    if (isDoctorateCourseHasValue)
                    {
                        switch (doctorateCourseValue)
                        {
                            case (int)Enums.DoctorateCourse.Phd:
                                doctorateCourse = Constants.Constants.DOCTORATE_PHD;
                                break;
                            case (int)Enums.DoctorateCourse.Mphill:
                                doctorateCourse = Constants.Constants.DOCTORATE_MPHILL;
                                break;
                            default:
                                validations.Append("Unknown value selected for Doctorate Course.\n");
                                break;
                        }
                        educationDoctorateDetails.DoctorateCourse = doctorateCourse;
                    }
                    else
                        validations.Append("Provide a integer value for Doctorate Course(ex.1 for Phd).\n");
                }
                else
                    validations.Append("Doctorate Course value is missing.\n");

                //pgSpecialization
                Console.WriteLine("Different values for PG Specialization:");
                List<string> doctorateSpecializationList = new List<string>();
                doctorateSpecializationList.Add(Constants.Constants.DOCTORATE_COMPUTERS);
                doctorateSpecializationList.Add(Constants.Constants.DOCTORATE_FINANCE);
                doctorateSpecializationList.Add(Constants.Constants.DOCTORATE_ELECTRICAL);
                doctorateSpecializationList.Add(Constants.Constants.DOCTORATE_CHEMICAL);
                doctorateSpecializationList.Add(Constants.Constants.DOCTORATE_MARKETING);

                Utility.Utility.PrintListValues(doctorateSpecializationList);
                
                Console.Write("Select a integer value for Doctorate Specialization(ex.1 for Computers):");
                string doctorateSpecialization = Console.ReadLine();
                if (!string.IsNullOrEmpty(doctorateSpecialization))
                {
                    int doctorateSpecializationValue = 0;
                    bool isDoctorateSpecializationHasValue = int.TryParse(doctorateSpecialization, out doctorateSpecializationValue);
                    if (isDoctorateSpecializationHasValue)
                    {
                        switch (doctorateSpecializationValue)
                        {
                            case (int)Enums.DoctorateSpecialization.Computers:
                                doctorateSpecialization = Constants.Constants.DOCTORATE_COMPUTERS;
                                break;
                            case (int)Enums.DoctorateSpecialization.Finance:
                                doctorateSpecialization = Constants.Constants.DOCTORATE_FINANCE;
                                break;
                            case (int)Enums.DoctorateSpecialization.Electrical:
                                doctorateSpecialization = Constants.Constants.DOCTORATE_ELECTRICAL;
                                break;
                            case (int)Enums.DoctorateSpecialization.Chemical:
                                doctorateSpecialization = Constants.Constants.DOCTORATE_CHEMICAL;
                                break;
                            case (int)Enums.DoctorateSpecialization.Marketing:
                                doctorateSpecialization = Constants.Constants.DOCTORATE_MARKETING;
                                break;
                            default:
                                validations.Append("Unknown value selected for Doctorate Specialization.\n");
                                break;
                        }
                        educationDoctorateDetails.DoctorateSpecialization = doctorateSpecialization;
                    }
                    else
                        validations.Append("Provide a integer value for Doctorate Specialization(ex.1 for Computers).\n");
                }
                else
                    validations.Append("Doctorate Specialization value is missing.\n");


                // Doctorate CourseType             
                Console.WriteLine("Different values for Doctorate CourseType:");
                List<string> doctorateCourseTypeList = new List<string>();
                doctorateCourseTypeList.Add(Constants.Constants.DOCTORATE_FULLTIME);
                doctorateCourseTypeList.Add(Constants.Constants.DOCTORATE_PARTTIME);
                doctorateCourseTypeList.Add(Constants.Constants.DOCTORATE_DISTANCE);

                Utility.Utility.PrintListValues(doctorateCourseTypeList);

                Console.Write("Select a integer value for Doctorate CourseType(ex.1 for Phd):");
                string doctorateCourseType = Console.ReadLine();
                if (!string.IsNullOrEmpty(doctorateCourseType))
                {
                    int doctorateCourseTypeValue = 0;
                    bool isDoctorateCourseTypeHasValue = int.TryParse(doctorateCourseType, out doctorateCourseTypeValue);
                    if (isDoctorateCourseTypeHasValue)
                    {
                        switch (doctorateCourseTypeValue)
                        {
                            case (int)Enums.DoctorateCourseType.FullTime:
                                doctorateCourseType = Constants.Constants.DOCTORATE_FULLTIME;
                                break;
                            case (int)Enums.DoctorateCourseType.PartTime:
                                doctorateCourseType = Constants.Constants.DOCTORATE_PARTTIME;
                                break;
                            case (int)Enums.DoctorateCourseType.Distance:
                                doctorateCourseType = Constants.Constants.DOCTORATE_DISTANCE;
                                break;
                            default:
                                validations.Append("Unknown value selected for Doctorate CourseType.\n");
                                break;
                        }
                        educationDoctorateDetails.DoctorateCourseType = doctorateCourseType;
                    }
                    else
                        validations.Append("Provide a integer value for Doctorate CourseType(ex.1 for Phd).\n");
                }
                else
                    validations.Append("Doctorate CourseType value is missing.\n");


                //Doctorate CourseStartingYear
                Console.Write("Enter Doctorate Course Starting Year:");
                string doctorateCourseStartingYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(doctorateCourseStartingYear))
                    educationDoctorateDetails.DoctorateCourseStartingYear = doctorateCourseStartingYear;
                else
                    validations.Append("Doctorate Course Starting Year value is missing.\n");

                //Doctorate CourseCourseEndingYear
                Console.Write("Enter Doctorate Course Ending Year:");
                string doctorateCourseEndingYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(doctorateCourseEndingYear))
                    educationDoctorateDetails.DoctorateCourseEndingYear = doctorateCourseEndingYear;
                else
                    validations.Append("Doctorate Course Ending Year value is missing.\n");

                // Doctorate GradingSystem
                Console.WriteLine("Different values for Doctorate Grading System Type:");
                List<string> doctorateGradingSystemList = new List<string>();
                doctorateGradingSystemList.Add(Constants.Constants.SCALE10_DOCTORATE_GRADING_SYSTEM);
                doctorateGradingSystemList.Add(Constants.Constants.SCALE4_DOCTORATE_GRADING_SYSTEM);
                doctorateGradingSystemList.Add(Constants.Constants.PASS_DOCTORATE_GRADING_SYSTEM);

                Utility.Utility.PrintListValues(doctorateGradingSystemList);

                Console.Write("Select a integer value for  Doctorate Grading System Type(ex.1 for Scale 10 Grading system):");
                string doctorateGradingSystem = Console.ReadLine();
                if (!string.IsNullOrEmpty(doctorateGradingSystem))
                {
                    int doctorateGradingSystemValue = 0;
                    bool isDoctorateGradingSystemHasValue = int.TryParse(doctorateGradingSystem, out doctorateGradingSystemValue);
                    if (isDoctorateGradingSystemHasValue)
                    {
                        switch (doctorateGradingSystemValue)
                        {
                            case (int)Enums.DoctorateGradingSystem.Scale10:
                                doctorateGradingSystem = Constants.Constants.SCALE10_DOCTORATE_GRADING_SYSTEM;
                                break;
                            case (int)Enums.DoctorateGradingSystem.Scale4:
                                doctorateGradingSystem = Constants.Constants.SCALE4_DOCTORATE_GRADING_SYSTEM;
                                break;
                            case (int)Enums.DoctorateGradingSystem.CourseRequiresPass:
                                doctorateGradingSystem = Constants.Constants.PASS_DOCTORATE_GRADING_SYSTEM;
                                break;
                            default:
                                validations.Append("Unknown value selected for Doctorate Grading system Type.\n");
                                break;
                        }
                        educationDoctorateDetails.DoctorateGradingSystem = doctorateGradingSystem;
                    }
                    else
                        validations.Append("Provide a integer value for Doctorate Grading system Type(ex.1 for scale 10 grading system).\n");
                }
                else
                    validations.Append("Doctorate Grading system Type value is missing.\n");

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
            return educationDoctorateDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Graduation education details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintDoctorateEducationDetails(EducationDoctorate details)
        {
            try
            {
                Console.WriteLine("\nCandidate Doctorate Education Details:");
                Console.WriteLine("___________________________________\n");
                Console.WriteLine($"Institute Name:{details.DoctorateInstitue}");
                Console.WriteLine($"Course:{details.DoctorateCourse}"); 
                Console.WriteLine($"Specialization:{details.DoctorateSpecialization}");      
                Console.WriteLine($"Course Type:{details.DoctorateCourseType}");     
                Console.WriteLine($"Course starting year:{details.DoctorateCourseStartingYear}"); 
                Console.WriteLine($"Course ending year:{details.DoctorateCourseEndingYear}"); 
                Console.WriteLine($"Grading system:{details.DoctorateGradingSystem}"); 
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
