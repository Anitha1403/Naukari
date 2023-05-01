using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class hplds services of PG education details
    /// </summary>
    public class EducationPGService
    {
        /// <summary>
        /// Method that Reads Candidate PG education details from console screen
        /// </summary>
        /// <returns></returns>
        public EducationPG ReadPGEducationDetails()
        {
            EducationPG educationPGDetails = new EducationPG();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("\nCandidate PG Details.");
                Console.WriteLine("_______________________________\n");
                //PG institute name
                Console.Write("Enter PG Institute name:");
                string pgInstitue=Console.ReadLine();
                if(!string.IsNullOrEmpty(pgInstitue))
                    educationPGDetails.PGInstitue = pgInstitue;
                else
                    validations.Append("PG Institute value is missing.\n");
                //pgCourse
                Console.WriteLine("Different values for PG Course:");
                List<string> pgCourseList = new List<string>();
                pgCourseList.Add(Constants.Constants.PG_MTECH);
                pgCourseList.Add(Constants.Constants.PG_MBA);
                pgCourseList.Add(Constants.Constants.PG_MCA);
                pgCourseList.Add(Constants.Constants.PG_MCOM);

                Utility.Utility.PrintListValues(pgCourseList);

                Console.Write("Select a integer value for PG Course(ex.1 for M.Tech):");
                string pgCourse = Console.ReadLine();
                if (!string.IsNullOrEmpty(pgCourse))
                {
                    int pgCourseValue = 0;
                    bool isPGCourseHasValue = int.TryParse(pgCourse, out pgCourseValue);
                    if (isPGCourseHasValue)
                    {
                        switch (pgCourseValue)
                        {
                            case (int)Enums.PGCourse.MTech:
                                pgCourse = Constants.Constants.PG_MTECH;
                                break;
                            case (int)Enums.PGCourse.MBA:
                                pgCourse = Constants.Constants.PG_MBA;
                                break;
                            case (int)Enums.PGCourse.MCA:
                                pgCourse = Constants.Constants.PG_MCA;
                                break;
                            case (int)Enums.PGCourse.MCom:
                                pgCourse = Constants.Constants.PG_MCOM;
                                break;
                            default:
                                validations.Append("Unknown value selected for PG Course.\n");
                                break;
                        }
                        educationPGDetails.PGCourse = pgCourse;
                    }
                    else
                        validations.Append("Provide a integer value for PG Course(ex.1 for M.Tech).\n");
                }
                else
                    validations.Append("PG Course value is missing.\n");

                //pgSpecialization
                Console.WriteLine("Different values for PG Specialization:");
                List<string> pgSpecializationList = new List<string>();
                pgSpecializationList.Add(Constants.Constants.PG_COMPUTERS);
                pgSpecializationList.Add(Constants.Constants.PG_FINANCE);
                pgSpecializationList.Add(Constants.Constants.PG_ELECTRICAL);
                pgSpecializationList.Add(Constants.Constants.PG_CHEMICAL);

                Utility.Utility.PrintListValues(pgSpecializationList);
                Console.Write("Select a integer value for PG Specialization(ex.1 for Computers):");
                string pgSpecialization = Console.ReadLine();
                if (!string.IsNullOrEmpty(pgSpecialization))
                {
                    int pgSpecializationValue = 0;
                    bool isPGSpecializationHasValue = int.TryParse(pgSpecialization, out pgSpecializationValue);
                    if (isPGSpecializationHasValue)
                    {
                        switch (pgSpecializationValue)
                        {
                            case (int)Enums.PGSpecialization.Computers:
                                pgSpecialization = Constants.Constants.PG_COMPUTERS;
                                break;
                            case (int)Enums.PGSpecialization.Finance:
                                pgSpecialization = Constants.Constants.PG_FINANCE;
                                break;
                            case (int)Enums.PGSpecialization.Electrical:
                                pgSpecialization = Constants.Constants.PG_ELECTRICAL;
                                break;
                            case (int)Enums.PGSpecialization.Chemical:
                                pgSpecialization = Constants.Constants.PG_CHEMICAL;
                                break;
                            default:
                                validations.Append("Unknown value selected for PG Specialization.\n");
                                break;
                        }
                        educationPGDetails.PGSpecialization = pgSpecialization;
                    }
                    else
                        validations.Append("Provide a integer value for PG Specialization(ex.1 for Computers).\n");
                }
                else
                    validations.Append("PG Specialization value is missing.\n");

                //pgCourseType
                Console.WriteLine("Different values for PG Course:");
                List<string> pgCourseTypeList = new List<string>();
                pgCourseTypeList.Add(Constants.Constants.PG_FULLTIME);
                pgCourseTypeList.Add(Constants.Constants.PG_PARTTIME);
                pgCourseTypeList.Add(Constants.Constants.PG_DISTANCE);               

                Utility.Utility.PrintListValues(pgCourseTypeList);

                Console.Write("Select a integer value for PG Course Type (ex.1 for Full time):");
                string pgCourseType = Console.ReadLine();
                if (!string.IsNullOrEmpty(pgCourseType))
                {
                    int pgCourseTypeValue = 0;
                    bool isPGCourseTypeHasValue = int.TryParse(pgCourseType, out pgCourseTypeValue);
                    if (isPGCourseTypeHasValue)
                    {
                        switch (pgCourseTypeValue)
                        {
                            case (int)Enums.PGCourseType.FullTime:
                                pgCourseType = Constants.Constants.PG_FULLTIME;
                                break;
                            case (int)Enums.PGCourseType.PartTime:
                                pgCourseType = Constants.Constants.PG_PARTTIME;
                                break;
                            case (int)Enums.PGCourseType.Distance:
                                pgCourseType = Constants.Constants.PG_DISTANCE;
                                break;                           
                            default:
                                validations.Append("Unknown value selected for PG Course Type.\n");
                                break;
                        }
                        educationPGDetails.PGCourseType = pgCourseType;
                    }
                    else
                        validations.Append("Provide a integer value for PG Course Type(ex.1 for Full time).\n");
                }
                else
                    validations.Append("PG Course Type value is missing.\n");

                //pgCourseStartingYear
                Console.Write("Enter PG Course Starting Year:");
                string pgCourseStartingYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(pgCourseStartingYear))
                    educationPGDetails.PGCourseStartingYear = pgCourseStartingYear;
                else
                   validations.Append("PG Course Starting Year value is missing.\n");


                //pgCourseCourseEndingYear
                Console.Write("Enter PG Course Ending Year:");
                string pgCourseEndingYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(pgCourseEndingYear))
                    educationPGDetails.PGCourseEndingYear = pgCourseEndingYear;
                else
                    validations.Append("PG Course Ending Year value is missing.\n");

                //pgGradingSystem
                Console.WriteLine("Different values for PG Grading System Type:");
                List<string> pgGradingSystemList = new List<string>();
                pgGradingSystemList.Add(Constants.Constants.SCALE10_PG_GRADING_SYSTEM);
                pgGradingSystemList.Add(Constants.Constants.SCALE4_PG_GRADING_SYSTEM);
                pgGradingSystemList.Add(Constants.Constants.PASS_PG_GRADING_SYSTEM);

                Utility.Utility.PrintListValues(pgGradingSystemList);

                Console.Write("Select a integer value for PG Grading System  Type (ex.1 for Scale 10 Grading system):");
                string pgGradingSystem = Console.ReadLine();
                if (!string.IsNullOrEmpty(pgGradingSystem))
                {
                    int pgGradingSystemValue = 0;
                    bool isPGGradingSystemHasValue = int.TryParse(pgGradingSystem, out pgGradingSystemValue);
                    if (isPGGradingSystemHasValue)
                    {
                        switch (pgGradingSystemValue)
                        {
                            case (int)Enums.PGGradingSystem.Scale10:
                                pgGradingSystem = Constants.Constants.SCALE10_PG_GRADING_SYSTEM;
                                break;
                            case (int)Enums.PGGradingSystem.Scale4:
                                pgGradingSystem = Constants.Constants.SCALE4_PG_GRADING_SYSTEM;
                                break;
                            case (int)Enums.PGGradingSystem.CourseRequiresPass:
                                pgGradingSystem = Constants.Constants.PASS_PG_GRADING_SYSTEM;
                                break;
                            default:
                                validations.Append("Unknown value selected for PG Grading system Type.\n");
                                break;
                        }
                        educationPGDetails.PGGradingSystem = pgGradingSystem;
                    }
                    else
                        validations.Append("Provide a integer value for PG Grading system Type(ex.1 for scale 10 grading system).\n");
                }
                else
                    validations.Append("PG Grading system Type value is missing.\n");

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
            return educationPGDetails;
        }
        /// <summary>
        /// Method that Prints Candidate PG education details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintPGEducationDetails(EducationPG details)
        {
            try
            {               
                Console.WriteLine("\nCandidate PG Education Details:");
                Console.WriteLine("__________________________________\n");
                Console.WriteLine($"Institute Name:{details.PGInstitue}");
                Console.WriteLine($"Course:{details.PGCourse}");
                Console.WriteLine($"Specialization:{details.PGSpecialization}");
                Console.WriteLine($"Course Type:{details.PGCourseType}");
                Console.WriteLine($"Course starting year:{details.PGCourseStartingYear}");
                Console.WriteLine($"Course ending year:{details.PGCourseEndingYear}");
                Console.WriteLine($"Grading system:{details.PGGradingSystem}");
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
