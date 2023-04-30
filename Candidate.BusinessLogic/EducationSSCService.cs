using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of SSC education details
    /// </summary>
    public class EducationSSCService
    {
        /// <summary>
        /// Method that Reads Candidate SSC/Tenth education details from console screen
        /// </summary>
        /// <returns></returns>
        public EducationSSC ReadSSCEducationDetails()
        {
            EducationSSC educationSSCDetails = new EducationSSC();
            StringBuilder validations = new StringBuilder();
            Regex rgx = new Regex(@"^[A-Za-z]+\d+.*$");
            try
            {
                Console.WriteLine("\nCandidate Tenth Education details");
                Console.WriteLine("_______________________________");
                //SchoolName
                Console.Write("\nEnter tenth School name:");
                string schoolName = Console.ReadLine();
                if (!string.IsNullOrEmpty(schoolName))
                    educationSSCDetails.SchoolName = schoolName;
                else
                    validations.Append("Tenth school name value is missing.\n");
                //Tenth board
                Console.WriteLine("\nDifferent values for Tenth Board:");
                List<string> tenthBoardList = new List<string>();
                tenthBoardList.Add(Constants.Constants.SSC_ANDHRA_PRADESH);
                tenthBoardList.Add(Constants.Constants.SSC_KARNATAKA);
                tenthBoardList.Add(Constants.Constants.SSC_TELENGANA);
                tenthBoardList.Add(Constants.Constants.SSC_TAMILANADU);

                Utility.Utility.PrintListValues(tenthBoardList);

                Console.Write("Select a integer value for tenth board(ex.1 for Andhra Pradesh):");
                string sscBoard=Console.ReadLine();
                if(!string.IsNullOrEmpty(sscBoard))
                {
                    int sscBoardValue = 0;
                    bool isSSCBoardHasValue = int.TryParse(sscBoard, out sscBoardValue);
                    if (isSSCBoardHasValue)
                    {
                        switch (sscBoardValue)
                        {
                            case (int)Enums.SSCBoard.AndhraPradesh:
                                sscBoard = Constants.Constants.SSC_ANDHRA_PRADESH;
                                break;
                            case (int)Enums.SSCBoard.Karnataka:
                                sscBoard = Constants.Constants.SSC_KARNATAKA;
                                break;
                            case (int)Enums.SSCBoard.Telengana:
                                sscBoard = Constants.Constants.SSC_TELENGANA;
                                break;
                            case (int)Enums.SSCBoard.Tamilanadu:
                                sscBoard = Constants.Constants.SSC_TAMILANADU;
                                break;
                            default:
                                validations.Append("Unknown value selected for tenth Board.\n");
                                break;
                        }
                        educationSSCDetails.TenthBoard = sscBoard;
                    }
                    else
                        validations.Append("Provide a integer value for tenth board(ex.1 for Andhra Pradesh).\n");
                }
                else
                    validations.Append("Tenth Board value is missing.\n");

                //Tenth passing year
                Console.Write("\nEnter tenth passing year:");
                string tenthPassingYear=Console.ReadLine();
                if (!string.IsNullOrEmpty(tenthPassingYear))
                    educationSSCDetails.TenthYearPassing = tenthPassingYear;
                else
                    validations.Append("Tenth year passing value is missing.\n");

                //TenthSchoolMedium
                Console.WriteLine("\nDifferent values for Tenth school medium:");
                List<string> tenthMediumList = new List<string>();
                tenthMediumList.Add(Constants.Constants.SSC_TELUGU);
                tenthMediumList.Add(Constants.Constants.SSC_ENGLISH);
                tenthMediumList.Add(Constants.Constants.SSC_SANSKRIT);
                tenthMediumList.Add(Constants.Constants.SSC_TAMIL);

                Utility.Utility.PrintListValues(tenthMediumList);

                Console.Write("Select a integer value for tenth school medium(ex.1 for Telugu):");
                string tenthMedium = Console.ReadLine();
                if (!string.IsNullOrEmpty(tenthMedium))
                {
                    int tenthMediumValue = 0;
                    bool isTenthMediumHasValue = int.TryParse(tenthMedium, out tenthMediumValue);
                    if (isTenthMediumHasValue)
                    {
                        switch (tenthMediumValue)
                        {
                            case (int)Enums.SSCMedium.Telugu:
                                tenthMedium = Constants.Constants.SSC_TELUGU;
                                break;
                            case (int)Enums.SSCMedium.English:
                                tenthMedium = Constants.Constants.SSC_ENGLISH;
                                break;
                            case (int)Enums.SSCMedium.Sanskrit:
                                tenthMedium = Constants.Constants.SSC_SANSKRIT;
                                break;
                            case (int)Enums.SSCMedium.Tamil:
                                tenthMedium = Constants.Constants.SSC_TAMIL;
                                break;
                            default:
                                validations.Append("Unknown value selected for Tenth school medium.\n");
                                break;
                        }
                        educationSSCDetails.TenthSchoolMedium = tenthMedium;
                    }
                    else
                        validations.Append("Provide a integer value for Tenth school medium(ex.1 for Telugu).\n");
                }
                else
                    validations.Append("SSC/Tenth school medium value is missing.\n");

                //totalMarks               
                Console.Write("\nEnter Tenth total marks:");
                string totalMarks = Console.ReadLine();
                if (!string.IsNullOrEmpty(totalMarks))
                {
                    if (rgx.IsMatch(totalMarks))
                    {
                        string marks = totalMarks;
                    }
                    else if (Regex.IsMatch(totalMarks, @"^-?\d+(?:\.\d+)?$"))
                    {
                        double tenthTotalMarks = double.Parse(totalMarks);
                        educationSSCDetails.TenthTotalMarks = tenthTotalMarks;
                    }
                    else
                    {
                        validations.Append("Please provide a decimal/integer value for  Tenth total marks (ex:86.34).\n");
                    }
                }
                else
                {
                    validations.Append("Tenth total marks value is missing.\n");
                }

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
            return educationSSCDetails;
        }
        /// <summary>
        /// Method that Prints Candidate SSC/Tenth education details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintSSCEducationDetails(EducationSSC details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate SSC/Tenth Education Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"School name:{details.SchoolName}");
                Console.WriteLine($"Board:{details.TenthBoard}");
                Console.WriteLine($"Year passing :{details.TenthYearPassing}");
                Console.WriteLine($"Medium:{details.TenthSchoolMedium}");
                Console.WriteLine($"Total marks:{details.TenthTotalMarks}");
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
