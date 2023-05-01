using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Education twelfth details
    /// </summary>
    public class EducationTwelfthService
    {
        /// <summary>
        /// Method that Reads Candidate Twelfth education details from console screen
        /// </summary>
        /// <returns></returns>
        public EducationTwelfth ReadTwelfthEducationDetails()
        {
            EducationTwelfth educationTwelfthDetails = new EducationTwelfth();
            StringBuilder validations = new StringBuilder();
            Regex rgx = new Regex(@"^[A-Za-z]+\d+.*$");
            try
            {
                Console.WriteLine("\nCandidate Twelfth Education details");
                Console.WriteLine("___________________________________\n");
                //College name
                Console.Write("Enter twelfth college name:");
                string collegeName = Console.ReadLine();
                if (!string.IsNullOrEmpty(collegeName))
                    educationTwelfthDetails.CollegeName = collegeName;
                else
                    validations.Append("Twelfth college name value is missing.\n");
                //Twelfth board
                Console.WriteLine("Different values for Twelfth Board:");
                List<string> TwelfthBoardList = new List<string>();
                TwelfthBoardList.Add(Constants.Constants.TWELFTH_ANDHRA_PRADESH);
                TwelfthBoardList.Add(Constants.Constants.TWELFTH_KARNATAKA);
                TwelfthBoardList.Add(Constants.Constants.TWELFTH_TELENGANA);
                TwelfthBoardList.Add(Constants.Constants.TWELFTH_TAMILANADU);

                Utility.Utility.PrintListValues(TwelfthBoardList);

                Console.Write("Select a integer value for Twelfth board(ex.1 for Andhra Pradesh):");
                string twelfthBoard = Console.ReadLine();
                if (!string.IsNullOrEmpty(twelfthBoard))
                {
                    int twelfthBoardValue = 0;
                    bool isTwelfthBoardHasValue = int.TryParse(twelfthBoard, out twelfthBoardValue);
                    if (isTwelfthBoardHasValue)
                    {
                        switch (twelfthBoardValue)
                        {
                            case (int)Enums.TwelfthBoard.AndhraPradesh:
                                twelfthBoard = Constants.Constants.TWELFTH_ANDHRA_PRADESH;
                                break;
                            case (int)Enums.TwelfthBoard.Karnataka:
                                twelfthBoard = Constants.Constants.TWELFTH_KARNATAKA;
                                break;
                            case (int)Enums.TwelfthBoard.Telengana:
                                twelfthBoard = Constants.Constants.TWELFTH_TELENGANA;
                                break;
                            case (int)Enums.TwelfthBoard.Tamilanadu:
                                twelfthBoard = Constants.Constants.TWELFTH_TAMILANADU;
                                break;
                            default:
                                validations.Append("Unknown value selected for twelfth Board.\n");
                                break;
                        }
                        educationTwelfthDetails.TwelfthBoard = twelfthBoard;
                    }
                    else
                        validations.Append("Provide a integer value for twelfth board(ex.1 for Andhra Pradesh).\n");
                }
                else
                    validations.Append("twelfth Board value is missing.\n");

                //Twelfth passing year
                Console.Write("Enter Twelfth passing year:");
                string twelfthPassingYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(twelfthPassingYear))
                    educationTwelfthDetails.TwelfthYearPassing = twelfthPassingYear;
                else
                    validations.Append("Twelfth year passing value is missing.\n");

                //Twelfth Medium
                Console.WriteLine("Different values for Twelfth medium:");
                List<string> twelfthMediumList = new List<string>();
                twelfthMediumList.Add(Constants.Constants.TWELFTH_TELUGU);
                twelfthMediumList.Add(Constants.Constants.TWELFTH_ENGLISH);
                twelfthMediumList.Add(Constants.Constants.TWELFTH_TAMIL);
                twelfthMediumList.Add(Constants.Constants.TWELFTH_KANNADA);
                twelfthMediumList.Add(Constants.Constants.TWELFTH_SANSKRIT);

                Utility.Utility.PrintListValues(twelfthMediumList);

                Console.Write("Select a integer value for Twelfth  medium(ex.1 for Telugu):");
                string twelfthMedium = Console.ReadLine();
                if (!string.IsNullOrEmpty(twelfthMedium))
                {
                    int twelfthMediumValue = 0;
                    bool isTenthMediumHasValue = int.TryParse(twelfthMedium, out twelfthMediumValue);
                    if (isTenthMediumHasValue)
                    {
                        switch (twelfthMediumValue)
                        {
                            case (int)Enums.TwelfthMedium.Telugu:
                                twelfthMedium = Constants.Constants.TWELFTH_TELUGU;
                                break;
                            case (int)Enums.TwelfthMedium.English:
                                twelfthMedium = Constants.Constants.TWELFTH_ENGLISH;
                                break;
                            case (int)Enums.TwelfthMedium.Tamil:
                                twelfthMedium = Constants.Constants.TWELFTH_TAMIL;
                                break;
                            case (int)Enums.TwelfthMedium.Kannada:
                                twelfthMedium = Constants.Constants.TWELFTH_KANNADA;
                                break;
                            case (int)Enums.TwelfthMedium.Sanskrit:
                                twelfthMedium = Constants.Constants.TWELFTH_SANSKRIT;
                                break;
                            
                            default:
                                validations.Append("Unknown value selected for Twelfth medium.\n");
                                break;
                        }
                        educationTwelfthDetails.TwelfthSchoolMedium = twelfthMedium;
                    }
                    else
                        validations.Append("Provide a integer value for Twelfth medium(ex.1 for Telugu).\n");
                }
                else
                    validations.Append("Twelfth medium value is missing.\n");

                //totalMarks               
                Console.Write("Enter Twelfth total marks:");
                string totalMarks = Console.ReadLine();
                if (!string.IsNullOrEmpty(totalMarks))
                {
                    int twelfthTotalMarks = 0;
                    bool isTwelfthTotalMarksHasValue = int.TryParse(totalMarks, out twelfthTotalMarks);
                    if (isTwelfthTotalMarksHasValue)
                    {
                        if (twelfthTotalMarks > 0)
                            educationTwelfthDetails.TwelfthMathMarks = twelfthTotalMarks;
                    }
                    else                    
                        validations.Append("Please provide a decimal/integer value for  twelfth total marks (ex:86.34).\n");                    
                }
                else
                    validations.Append("Twelfth total marks value is missing.\n");

                // English marks
                Console.Write("Enter Twelfth English marks:");
                string strEnglishMarks = Console.ReadLine();

                if (!string.IsNullOrEmpty(strEnglishMarks))
                {
                    int englishMarks = 0;
                    bool isEnglishMarksHasValue = int.TryParse(strEnglishMarks, out englishMarks);
                    if (isEnglishMarksHasValue)
                    {
                        if (englishMarks > 0)
                            educationTwelfthDetails.TwelfthMathMarks = englishMarks;

                    }
                    else                    
                        validations.Append("Provide integer value for Twelfth English marks (ex.3).\n");
                }
                else
                    validations.Append("Twelfth English marks value is missing.\n");                

                // Maths marks
                Console.Write("Enter Twelfth Maths marks:");
                string strMathsMarks = Console.ReadLine();

                if (!string.IsNullOrEmpty(strMathsMarks))
                {
                    int mathsMarks = 0;
                    bool isMathsMarksHasValue = int.TryParse(strMathsMarks, out mathsMarks);
                    if (isMathsMarksHasValue)
                    {
                        if(mathsMarks>0)
                            educationTwelfthDetails.TwelfthMathMarks = mathsMarks;

                    }                   
                    else                    
                        validations.Append("Provide integer value for Twelfth Maths marks (ex.3).\n"); 
                }
                else                
                    validations.Append("Twelfth Maths marks value is missing.\n");
                

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
            return educationTwelfthDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Twelfth education details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintTwelfthEducationDetails(EducationTwelfth details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Twelfth Education Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"College name:{details.CollegeName}");
                Console.WriteLine($"Board:{details.TwelfthBoard}");
                Console.WriteLine($"Year passing :{details.TwelfthYearPassing}");
                Console.WriteLine($"Medium:{details.TwelfthSchoolMedium}");
                Console.WriteLine($"Total marks:{details.TwelfthTotalMarks}");
                Console.WriteLine($"English marks:{details.TwelfthEnglishMarks}");
                Console.WriteLine($"Maths marks:{details.TwelfthMathMarks}");
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
