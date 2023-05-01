using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Personal Details
    /// </summary>
    public class PersonalDetailsService
    {
        /// <summary>
        /// Method that reads Candidate personal details from console screen
        /// </summary>
        public PersonalDetails ReadPersonalDetails()
        {
            PersonalDetails personalDetails = new PersonalDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                // Candidate Personal Details
                Console.WriteLine("Provide Candidate Personal Details:");
                Console.WriteLine("_________________________\n");
                //Candidate First Name
                Console.Write("Enter First Name:");
                string firstName = Console.ReadLine();
                if (!string.IsNullOrEmpty(firstName))
                    personalDetails.FirstName = firstName;
                else
                    validations.Append("Candidate First Name is missing.\n");

                //Candidate Middle Name
                Console.Write("Enter Middle Name:");
                string middleName = Console.ReadLine();
                if (!string.IsNullOrEmpty(middleName))
                    personalDetails.MiddleName = middleName;
                else
                    validations.Append("Candidate First Name is missing.\n");

                //Candidate LastName
                Console.Write("Enter Last Name:");
                string lastName = Console.ReadLine();
                if (!string.IsNullOrEmpty(lastName))
                    personalDetails.LastName = lastName;
                else
                    validations.Append("Candidate First Name is missing.\n");

                //Candidate Gender
                Console.WriteLine("\nDifferent values for Gender:");
                List<string> genderList = new List<string>();
                genderList.Add(Constants.Constants.MALE);
                genderList.Add(Constants.Constants.FEMALE);
                genderList.Add(Constants.Constants.TRANSGENDER);
                
                Utility.Utility.PrintListValues(genderList);

                Console.Write("Select a value for Gender(Ex. Select 1 for Male):");
                int genderOutput = 0;
                bool isGenderHasValue=int.TryParse(Console.ReadLine(), out genderOutput);
                string genderValue=string.Empty;

                if (isGenderHasValue)
                {
                    switch (genderOutput)
                    {
                        case (int)Enums.Gender.Male:
                            genderValue =Constants.Constants.MALE;
                            break;
                        case (int)Enums.Gender.Female:
                            genderValue = Constants.Constants.FEMALE;
                            break;
                        case (int)Enums.Gender.Transgender:
                            genderValue = Constants.Constants.TRANSGENDER;
                            break;
                         default:
                            validations.Append("Unknown Value for Gender is selected.\n");
                            break;
                    }
                    personalDetails.Gender = genderValue;
                }
                else
                {
                    validations.Append("Please select integer value for Gender(Ex.1 for Male)\n");
                }

                //CandidateType
                Console.WriteLine("\nDifferent values for CandidateType:");
                List<string> candidateTypeList = new List<string>();
                candidateTypeList.Add(Constants.Constants.SINGLE_PARENT);
                candidateTypeList.Add(Constants.Constants.WORKING_MOTHER);
                candidateTypeList.Add(Constants.Constants.SERVED_IN_MILITARY);
                candidateTypeList.Add(Constants.Constants.RETIRED);
                candidateTypeList.Add(Constants.Constants.LGBTQ);

                Utility.Utility.PrintListValues(candidateTypeList);

                Console.Write("Select a value for CandidateType(Ex. Select 1 for Single Parent):");
                int candidateTypeOutput = 0;
                bool isCandidateTypeHasValue = int.TryParse(Console.ReadLine(), out candidateTypeOutput);
                string candidateTypeValue = string.Empty;

                if (isCandidateTypeHasValue)
                {
                    switch (candidateTypeOutput)
                    {
                        case (int)Enums.CandidateType.SingleParent:
                            candidateTypeValue = Constants.Constants.SINGLE_PARENT;
                            break;
                        case (int)Enums.CandidateType.WorkingMother:
                            candidateTypeValue = Constants.Constants.WORKING_MOTHER;
                            break;
                        case (int)Enums.CandidateType.ServedInMilitary:
                            candidateTypeValue = Constants.Constants.SERVED_IN_MILITARY;
                            break;
                        case (int)Enums.CandidateType.Retired:
                            candidateTypeValue = Constants.Constants.RETIRED;
                            break;
                        case (int)Enums.CandidateType.LGBTQ:
                            candidateTypeValue = Constants.Constants.LGBTQ;
                            break;
                        default:
                            validations.Append("Unknown Value for CandidateType is selected.\n");
                            break;
                    }
                    personalDetails.CandidateType = candidateTypeValue;
                }
                else
                {
                    validations.Append("Please select integer value for CandidateType(Ex.1 for Single Parent)\n");
                }

                //Candidate Marital Status
                Console.WriteLine("\nDifferent values for Marital Status:");
                List<string> maritalStatusList = new List<string>();
                maritalStatusList.Add(Constants.Constants.UN_MARRIED);
                maritalStatusList.Add(Constants.Constants.MARRIED);
                maritalStatusList.Add(Constants.Constants.WIDOWED);
                maritalStatusList.Add(Constants.Constants.DIVORCED);
                maritalStatusList.Add(Constants.Constants.SEPARATED);

                Utility.Utility.PrintListValues(maritalStatusList);

                Console.Write("Select a value for MaritalStatus(Ex. Select 1 for UnMarried):");
                int maritalStatusOutput = 0;
                bool isMaritalStatusHasValue = int.TryParse(Console.ReadLine(), out maritalStatusOutput);
                string maritalStatusValue = string.Empty;

                if (isMaritalStatusHasValue)
                {
                    switch (maritalStatusOutput)
                    {
                        case (int)Enums.MaritalStatus.Unmarried:
                            maritalStatusValue = Constants.Constants.UN_MARRIED;
                            break;
                        case (int)Enums.MaritalStatus.Married:
                            maritalStatusValue = Constants.Constants.MARRIED;
                            break;
                        case (int)Enums.MaritalStatus.Widowed:
                            maritalStatusValue = Constants.Constants.WIDOWED;
                            break;
                        case (int)Enums.MaritalStatus.Divorced:
                            maritalStatusValue = Constants.Constants.DIVORCED;
                            break;
                        case (int)Enums.MaritalStatus.Separated:
                            maritalStatusValue = Constants.Constants.SEPARATED;
                            break;
                        default:
                            validations.Append("Unknown Value for MaritalStatus is selected.\n");
                            break;
                    }
                    personalDetails.MaritalStatus = maritalStatusValue;
                }
                else
                {
                    validations.Append("Please select integer value for MarialStatus(Ex.2 for Married).\n");
                }

                //Candidate Date Of Birth
                Console.Write("\nEnter Date of Birth:");
                string dateOfBirth = Console.ReadLine();
                if (!string.IsNullOrEmpty(dateOfBirth))
                    personalDetails.DateofBirth = dateOfBirth;
                else
                    validations.Append("Candidate DateOfBirth is missing.\n");

                //Candidate Category
                Console.WriteLine("\nDifferent values for Category:");
                List<string> categoryList = new List<string>();
                categoryList.Add(Constants.Constants.GENERAL);
                categoryList.Add(Constants.Constants.SC);
                categoryList.Add(Constants.Constants.ST);
                categoryList.Add(Constants.Constants.OBC_CREAMY);
                categoryList.Add(Constants.Constants.OBC_NON_CREAMY);

                Utility.Utility.PrintListValues(categoryList);

                Console.Write("Select a value for Category(Ex. Select 1 for General):");
                int categoryOutput = 0;
                bool isCategoryHasValue = int.TryParse(Console.ReadLine(), out categoryOutput);
                string categoryValue = string.Empty;

                if (isCategoryHasValue)
                {
                    switch (categoryOutput)
                    {
                        case (int)Enums.Category.General:
                            categoryValue = Constants.Constants.GENERAL;
                            break;
                        case (int)Enums.Category.ScheduledCaste:
                            categoryValue = Constants.Constants.SC;
                            break;
                        case (int)Enums.Category.ScheduledTribe:
                            categoryValue = Constants.Constants.ST;
                            break;
                        case (int)Enums.Category.OBCCreamy:
                            categoryValue = Constants.Constants.OBC_CREAMY;
                            break;
                        case (int)Enums.Category.OBCNonCreamy:
                            categoryValue = Constants.Constants.OBC_NON_CREAMY;
                            break;
                        default:
                            validations.Append("Unknown Value for Category is selected.\n");
                            break;
                    }
                    personalDetails.Category = categoryValue;
                }
                else
                {
                    validations.Append("Please select integer value for Category(Ex.1 for General)\n");
                }

                //Candidate Differently abled
                Console.Write("\nAre you differently abled?(Enter True/False):");                
                string differentlyAbledValue =Console.ReadLine();
                if (!string.IsNullOrEmpty(differentlyAbledValue))
                {
                    if (differentlyAbledValue.ToLower() == "true" || differentlyAbledValue.ToLower() == "false")
                    {
                        bool differentlyAbled = Convert.ToBoolean(differentlyAbledValue);
                        personalDetails.DifferentlyAbled = differentlyAbled;
                    }
                    else
                        validations.Append("Provide a value for Differently abled(ex.true for differently abled).\n");
                }
                else
                    validations.Append("Differently abled value is missing.\n");

                //Candidate Career Break
                Console.Write("\nDo you have any Career Break?(Enter True/False):");
                string careerBreakValue = Console.ReadLine();
                if (!string.IsNullOrEmpty(careerBreakValue))
                {
                    if (careerBreakValue.ToLower() == "true" || careerBreakValue.ToLower() == "false")
                    {
                        bool careerBreak = Convert.ToBoolean(careerBreakValue);
                        personalDetails.CareerBreak = careerBreak;
                    }
                    else
                        validations.Append("Provide a value for CareerBreak(ex.true/false).\n");
                }
                else
                validations.Append("Career break value is missing.\n");


            //Candidate WorkPermitUSA
            Console.WriteLine("\nDifferent values for WorkPermitUSA:");
                List<string> workPermitUSAList = new List<string>();
                workPermitUSAList.Add(Constants.Constants.HAVE_US_H1_VISA);
                workPermitUSAList.Add(Constants.Constants.NEED_US_H1_VISA);
                workPermitUSAList.Add(Constants.Constants.US_TN_PERMIT_HOLDER);
                workPermitUSAList.Add(Constants.Constants.US_GREEN_CARD_HOLDER);
                workPermitUSAList.Add(Constants.Constants.US_CITIZEN);
                workPermitUSAList.Add(Constants.Constants.AUTHORIZED_TO_WORK_IN_US);
                workPermitUSAList.Add(Constants.Constants.US);

                Utility.Utility.PrintListValues(workPermitUSAList);

                Console.Write("Select a value for workPermitUSAList(Ex. Select 1 for Have US H1 Visa):");
                int workPermitUSAOutput = 0;
                bool isWorkPermitUSAHasValue = int.TryParse(Console.ReadLine(), out workPermitUSAOutput);
                string workPermitUSAValue = string.Empty;

                if (isWorkPermitUSAHasValue)
                {
                    switch (workPermitUSAOutput)
                    {
                        case (int)Enums.WorkPermitUSA.HaveUSH1Visa:
                            workPermitUSAValue = Constants.Constants.HAVE_US_H1_VISA;
                            break;
                        case (int)Enums.WorkPermitUSA.NeedUSH1Visa:
                            workPermitUSAValue = Constants.Constants.NEED_US_H1_VISA;
                            break;
                        case (int)Enums.WorkPermitUSA.USTNPermitHolder:
                            workPermitUSAValue = Constants.Constants.US_TN_PERMIT_HOLDER;
                            break;
                        case (int)Enums.WorkPermitUSA.USGreenCardHolder:
                            workPermitUSAValue = Constants.Constants.US_GREEN_CARD_HOLDER;
                            break;
                        case (int)Enums.WorkPermitUSA.USCitizen:
                            workPermitUSAValue = Constants.Constants.US_CITIZEN;
                            break;
                        case (int)Enums.WorkPermitUSA.AuthorizedtoworkInUS:
                            workPermitUSAValue = Constants.Constants.AUTHORIZED_TO_WORK_IN_US;
                            break;
                        case (int)Enums.WorkPermitUSA.US:
                            workPermitUSAValue = Constants.Constants.US;
                            break;
                        default:
                            validations.Append("Unknown Value for workPermitUSA is selected.\n");
                            break;
                    }
                    personalDetails.WorkPermitUSA = workPermitUSAValue;
                }
                else
                {
                    validations.Append("Please select integer value for workPermitUSAVaue(Ex.2 for ).\n");
                }

                //Candidate WorkPermitOther Countries
                Console.WriteLine("\nDifferent values for WorkPermit Other Counries:");
                List<string> workPermitOtherCountriesList = new List<string>();
                workPermitOtherCountriesList.Add(Constants.Constants.INDIA);
                workPermitOtherCountriesList.Add(Constants.Constants.AUSTRALIA);
                workPermitOtherCountriesList.Add(Constants.Constants.NEWZEALAND);
                workPermitOtherCountriesList.Add(Constants.Constants.ENGLAND);
                workPermitOtherCountriesList.Add(Constants.Constants.IRLAND);
                workPermitOtherCountriesList.Add(Constants.Constants.USA);
              
                Utility.Utility.PrintListValues(workPermitOtherCountriesList);

                Console.Write("Select a value for workPermitOtherCountriesList(Ex. Select 1 for INDIA):");
                int workPermitOtherCounryOutput = 0;
                bool isWorkPermitOtherCountryHasValue = int.TryParse(Console.ReadLine(), out workPermitOtherCounryOutput);
                string workPermitOtherCountryValue = string.Empty;

                if (isWorkPermitOtherCountryHasValue)
                {
                    switch (workPermitOtherCounryOutput)
                    {
                        case (int)Enums.WorkPermitOtherCountry.India:
                            workPermitOtherCountryValue = Constants.Constants.INDIA;
                            break;
                        case (int)Enums.WorkPermitOtherCountry.Australia:
                            workPermitOtherCountryValue = Constants.Constants.AUSTRALIA;
                            break;
                        case (int)Enums.WorkPermitOtherCountry.NewZealand:
                            workPermitOtherCountryValue = Constants.Constants.NEWZEALAND;
                            break;
                        case (int)Enums.WorkPermitOtherCountry.England:
                            workPermitOtherCountryValue = Constants.Constants.ENGLAND;
                            break;
                        case (int)Enums.WorkPermitOtherCountry.Irland:
                            workPermitOtherCountryValue = Constants.Constants.IRLAND;
                            break;
                        case (int)Enums.WorkPermitOtherCountry.USA:
                            workPermitOtherCountryValue = Constants.Constants.USA;
                            break;                        
                        default:
                            validations.Append("Unknown Value for workPermitOtherCountries is selected.\n");
                            break;
                    }
                    personalDetails.WorkPermitOtherCountries = workPermitOtherCountryValue;
                }
                else
                {
                    validations.Append("Please select integer value for workPermitOtherCountryValue(Ex.2 for Australia).\n");
                }

                //Candidate Work Status 
                Console.WriteLine("\nDifferent values for WorkStatus:");
                List<string> workStatusList = new List<string>();
                workStatusList.Add(Constants.Constants.FRESHER);
                workStatusList.Add(Constants.Constants.EXPERIENCED);
               
                Utility.Utility.PrintListValues(workStatusList);

                Console.Write("Select a value for workStatusList(Ex. Select 1 for Fresher):");
                int workStatusOutput = 0;
                bool isworkStatusHasValue = int.TryParse(Console.ReadLine(), out workStatusOutput);
                string workStatusValue = string.Empty;

                if (isworkStatusHasValue)
                {
                    switch (workStatusOutput)
                    {
                        case (int)Enums.WorkStatus.Fresher:
                            workStatusValue = Constants.Constants.FRESHER;
                            break;
                        case (int)Enums.WorkStatus.Experienced:
                            workStatusValue = Constants.Constants.EXPERIENCED;
                            break;                        
                        default:
                            validations.Append("Unknown Value for WorkStatus is selected.\n");
                            break;
                    }
                    personalDetails.WorkStatus = workStatusValue;
                }
                else
                {
                    validations.Append("Please select integer value for workStatusValue(Ex.2 for Experienced).\n");
                }

                //Candidate Notice Period 
                Console.WriteLine("\nDifferent values for Notice Period:");                
                List<string> noticePeriodList = new List<string>();
                noticePeriodList.Add(Constants.Constants.FIFTEEN_DAYSORLESS);
                noticePeriodList.Add(Constants.Constants.ONE_MONTH);
                noticePeriodList.Add(Constants.Constants.TWO_MONHS);
                noticePeriodList.Add(Constants.Constants.THREE_MONTHS);
                noticePeriodList.Add(Constants.Constants.MORE_THAN_THREE_MONTHS);                

                Utility.Utility.PrintListValues(noticePeriodList);

                Console.Write("Select a value for Notice Period (Ex. Select 2 for one month):");
                int noticePeriodOutput = 0;
                bool isNoticePeriodOutputHasValue = int.TryParse(Console.ReadLine(), out noticePeriodOutput);
                string noticePeroidValue = string.Empty;

                if (isWorkPermitOtherCountryHasValue)
                {
                    switch (noticePeriodOutput)
                    {
                        case (int)Enums.NoticePeriod.FifteenDaysOrLess:
                            noticePeroidValue = Constants.Constants.FIFTEEN_DAYSORLESS;
                            break;
                        case (int)Enums.NoticePeriod.OneMonth:
                            noticePeroidValue = Constants.Constants.ONE_MONTH;
                            break;
                        case (int)Enums.NoticePeriod.TwoMonths:
                            noticePeroidValue = Constants.Constants.TWO_MONHS;
                            break;
                        case (int)Enums.NoticePeriod.ThreeMonths:
                            noticePeroidValue = Constants.Constants.THREE_MONTHS;
                            break;
                        case (int)Enums.NoticePeriod.MoreThanThreeMonths:
                            noticePeroidValue = Constants.Constants.MORE_THAN_THREE_MONTHS;
                            break;
                        default:
                            validations.Append("Unknown Value for notice period is selected.\n");
                            break;
                    }
                    personalDetails.NoticePeriods = noticePeroidValue;
                }
                else
                {
                    validations.Append("Please select integer value for noticePeroidValue(Ex.2 for one month).\n");
                }


                //Validation error messages
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine("\n\nValidation Errors:\n{0}", validations);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }
            return personalDetails;
        }
        /// <summary>
        /// Method that prints Candidate personal details to console screen
        /// </summary>
        public void PrintPersonalDetails(PersonalDetails Details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Personal Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine($"Name:{Details.FirstName} {Details.MiddleName} {Details.LastName}");
                Console.WriteLine($"Gender:{Details.Gender}");
                Console.WriteLine($"Candidate Type:{Details.CandidateType}");
                Console.WriteLine($"Marital Satus:{Details.MaritalStatus}");
                Console.WriteLine($"Date of Birth:{Details.DateofBirth}");
                Console.WriteLine($"Category:{Details.Category}");
                if(Details.DifferentlyAbled)
                    Console.WriteLine($"Differently Abled:{Constants.Constants.DIFFERENTLY_ABLED}");
                else
                    Console.WriteLine($"Differently Abled:{Constants.Constants.DIFFERENTLY_NOT_ABLED}");

                if (Details.CareerBreak)
                    Console.WriteLine($"Career Break:{Constants.Constants.CAREER_BREAK}");
                else
                    Console.WriteLine($"Career Break:{Constants.Constants.NO_CAREER_BREAK}");

                Console.WriteLine($"Work Permit USA:{Details.WorkPermitUSA}");
                Console.WriteLine($"Work Permit Other Countries:{Details.WorkPermitOtherCountries}");
                Console.WriteLine($"Work Status:{Details.WorkStatus}");
                Console.WriteLine($"Notice Period:{Details.NoticePeriods}");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Mesage: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
            }
        }
    }
}
