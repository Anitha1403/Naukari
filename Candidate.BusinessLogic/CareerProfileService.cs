using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    //Class holds that  read and print deatils of  Candidate Career profile services 
    public class CareerProfileService
    {

        //Read Career profile details
        public CareerProfile ReadCareerProfileDetails()
        {
            CareerProfile careerProfile = new CareerProfile();
            StringBuilder validations = new StringBuilder();
            try
            {
                //Current Industry   
                Console.WriteLine("\nDifferent values for Current industry:");
                List<string> currentIndustryList = new List<string>();
                currentIndustryList.Add(Constants.Constants.HARDWARE_NETWORKING);
                currentIndustryList.Add(Constants.Constants.E_COMMERCE);
                currentIndustryList.Add(Constants.Constants.BANKING);
                currentIndustryList.Add(Constants.Constants.INSURANCE);
                currentIndustryList.Add(Constants.Constants.AGRICULTURE);
                currentIndustryList.Add(Constants.Constants.E_LEARNING);
                currentIndustryList.Add(Constants.Constants.INFORMATION_TECHNOLOGY);
              
                Utility.Utility.PrintListValues(currentIndustryList);

                Console.Write("Select a value for Current Industry(Ex. Select 3 for Banking.):");
                int currentIndustryOutput = 0;
                bool isCurrentIndustryHasValue = int.TryParse(Console.ReadLine(), out currentIndustryOutput);
                string currentIndustryValue = string.Empty;

                if (isCurrentIndustryHasValue)
                {
                    switch (currentIndustryOutput)
                    {
                        case (int)Enums.CurrentIndustry.HardwareAndNeworking1:
                            currentIndustryValue = Constants.Constants.HARDWARE_NETWORKING;
                            break;
                        case (int)Enums.CurrentIndustry.ECommerce:
                            currentIndustryValue = Constants.Constants.E_COMMERCE;
                            break;
                        case (int)Enums.CurrentIndustry.Banking:
                            currentIndustryValue = Constants.Constants.BANKING;
                            break;
                        case (int)Enums.CurrentIndustry.Insurance:
                            currentIndustryValue = Constants.Constants.INSURANCE;
                            break;
                        case (int)Enums.CurrentIndustry.Agriculture:
                            currentIndustryValue = Constants.Constants.AGRICULTURE;
                            break;
                        case (int)Enums.CurrentIndustry.ELearning:
                            currentIndustryValue = Constants.Constants.E_LEARNING;
                            break;
                        case (int)Enums.CurrentIndustry.InformaionTechnology:
                            currentIndustryValue = Constants.Constants.INFORMATION_TECHNOLOGY;
                            break;
                        default:
                            validations.Append("Unknown Value for Current industry is selected.\n");
                            break;
                    }
                    careerProfile.CurrentIndustry = currentIndustryValue;
                }
                else
                {
                    validations.Append("Please select integer value for Current industry(Ex.3 for Banking)\n");
                }

                //Department   
                Console.WriteLine("\nDifferent values for Department:");
                List<string> departmentList = new List<string>();
                departmentList.Add(Constants.Constants.DATA_SCIENCE_AND_ANALYTICS);
                departmentList.Add(Constants.Constants.PRODUCT_MANAGEMENT);
                departmentList.Add(Constants.Constants.IT_INFORMATION_SECURITY);
                departmentList.Add(Constants.Constants.CONSULTING);
                departmentList.Add(Constants.Constants.TEACHING_TRAINING);
               
                Utility.Utility.PrintListValues(departmentList);

                Console.Write("Select a value for Department(Ex. Select 1 for Data science & analytics.):");
                int departmentOutput = 0;
                bool isDepartmentHasValue = int.TryParse(Console.ReadLine(), out departmentOutput);
                string departmentValue = string.Empty;

                if (isDepartmentHasValue)
                {
                    switch (departmentOutput)
                    {
                        case (int)Enums.Department.DataSceinceAndAnalytics:
                            departmentValue = Constants.Constants.DATA_SCIENCE_AND_ANALYTICS;
                            break;
                        case (int)Enums.Department.ProductManagement:
                            departmentValue = Constants.Constants.PRODUCT_MANAGEMENT;
                            break;
                        case (int)Enums.Department.ITAndInformationSecurity:
                            departmentValue = Constants.Constants.IT_INFORMATION_SECURITY;
                            break;
                        case (int)Enums.Department.Consulting:
                            departmentValue = Constants.Constants.CONSULTING;
                            break;
                        case (int)Enums.Department.TeachingAndTraining:
                            departmentValue = Constants.Constants.TEACHING_TRAINING;
                            break;
                       default:
                            validations.Append("Unknown Value for Department is selected.\n");
                            break;
                    }
                    careerProfile.Department = departmentValue;
                }
                else
                {
                    validations.Append("Please select integer value for Department(Ex.1 for Data science & Analytics)\n");
                }

                //Desired Job type
                Console.WriteLine("\nDifferent values for Desired Job type:");
                List<string> jobTypeList = new List<string>();
                jobTypeList.Add(Constants.Constants.PERMANENT_TYPE);
                jobTypeList.Add(Constants.Constants.CONTRACTUAL_TYPE);
               
                Utility.Utility.PrintListValues(jobTypeList);

                Console.Write("Select a value for Desired Job type(Ex. Select 1 for Permanent):");
                int desiredJobTypeOutput = 0;
                bool isDesiredJobTypeHasValue = int.TryParse(Console.ReadLine(), out desiredJobTypeOutput);
                string desiredJobypeValue = string.Empty;

                if (isDesiredJobTypeHasValue)
                {
                    switch (desiredJobTypeOutput)
                    {
                        case (int)Enums.DesiredType.Permanent:
                            desiredJobypeValue = Constants.Constants.PERMANENT_TYPE;
                            break;
                        case (int)Enums.DesiredType.Contractual:
                            desiredJobypeValue = Constants.Constants.CONTRACTUAL_TYPE;
                            break;                        
                        default:
                            validations.Append("Unknown Value for Desired Job type is selected.\n");
                            break;
                    }
                    careerProfile.DesiredJobType = desiredJobypeValue;
                }
                else
                {
                    validations.Append("Please select integer value for Desired job type(Ex.1 for Permanent)\n");
                }

                //Desired Job type
                Console.WriteLine("\nDifferent values for Desired Employment type:");
                List<string> employmentTypeList = new List<string>();
                employmentTypeList.Add(Constants.Constants.FULL_TIME);
                employmentTypeList.Add(Constants.Constants.PART_TIME);

                Utility.Utility.PrintListValues(employmentTypeList);

                Console.Write("Select a value for Desired Employment type(Ex. Select 1 for Full time):");
                int desiredEmploymentTypeOutput = 0;
                bool isDesiredEmploymentTypeHasValue = int.TryParse(Console.ReadLine(), out desiredEmploymentTypeOutput);
                string desiredEmploymentypeValue = string.Empty;

                if (isDesiredEmploymentTypeHasValue)
                {
                    switch (desiredEmploymentTypeOutput)
                    {
                        case (int)Enums.DesiredEmploymentType.FullTime:
                            desiredEmploymentypeValue = Constants.Constants.FULL_TIME;
                            break;
                        case (int)Enums.DesiredEmploymentType.PartTime:
                            desiredEmploymentypeValue = Constants.Constants.PART_TIME;
                            break;
                        default:
                            validations.Append("Unknown Value for Desired Employment type is selected.\n");
                            break;
                    }
                    careerProfile.DesiredEmploymentType = desiredEmploymentypeValue;
                }
                else
                {
                    validations.Append("Please select integer value for Desired Employment type(Ex.1 for full time)\n");
                }

                //Preffered shift
                Console.WriteLine("\nDifferent values for Preffered shift:");
                List<string> prefferedShiftList = new List<string>();
                prefferedShiftList.Add(Constants.Constants.DAY);
                prefferedShiftList.Add(Constants.Constants.NIGHT);
                prefferedShiftList.Add(Constants.Constants.FLEXIBLE);

                Utility.Utility.PrintListValues(prefferedShiftList);

                Console.Write("Select a value for Preffered shift(Ex. Select 1 for day):");
                int prefferedShiftOutput = 0;
                bool isPrefferedShiftHasValue = int.TryParse(Console.ReadLine(), out prefferedShiftOutput);
                string prefferedShiftValue = string.Empty;

                if (isPrefferedShiftHasValue)
                {
                    switch (prefferedShiftOutput)
                    {
                        case (int)Enums.PrefferedShift.Day:
                            prefferedShiftValue = Constants.Constants.DAY;
                            break;
                        case (int)Enums.PrefferedShift.Night:
                            prefferedShiftValue = Constants.Constants.NIGHT;
                            break;
                        case (int)Enums.PrefferedShift.Flexible:
                            prefferedShiftValue = Constants.Constants.FLEXIBLE;
                            break;
                        default:
                            validations.Append("Unknown Value for preffered shift is selected.\n");
                            break;
                    }
                    careerProfile.PreferredShift = prefferedShiftValue;
                }
                else
                {
                    validations.Append("Please select integer value for Preffered shif(Ex.1 for Day)\n");
                }

                //Preffered Location
                Console.WriteLine("\nDifferent values for Preffered Location:");
                List<string> prefferedLocationList = new List<string>();
                prefferedLocationList.Add(Constants.Constants.DAY);
                prefferedLocationList.Add(Constants.Constants.NIGHT);
                prefferedLocationList.Add(Constants.Constants.FLEXIBLE);

                Utility.Utility.PrintListValues(prefferedLocationList);

                Console.Write("Select a value for Preffered Location(Ex. Select 1 for Bangalore):");
                int prefferedLocationOutput = 0;
                bool isPrefferedLocationHasValue = int.TryParse(Console.ReadLine(), out prefferedLocationOutput);
                string prefferedLocationValue = string.Empty;

                if (isPrefferedLocationHasValue)
                {
                    switch (prefferedLocationOutput)
                    {
                        case (int)Enums.PrefferedLocation.Bangalore:
                            prefferedLocationValue = Constants.Constants.BANGALORE;
                            break;
                        case (int)Enums.PrefferedLocation.Hyderabad:
                            prefferedLocationValue = Constants.Constants.HYDERABAD;
                            break;
                        case (int)Enums.PrefferedLocation.Chennai:
                            prefferedLocationValue = Constants.Constants.CHENNAI;
                            break;
                        default:
                            validations.Append("Unknown Value for Preffered Location is selected.\n");
                            break;
                    }
                    careerProfile.PreferredWorklocation = prefferedLocationValue;
                }
                else
                {
                    validations.Append("Please select integer value for Preffered Location(Ex.1 for Bangaore)\n");
                }

                //Expected salary               
                Console.Write("Enter Expected salary:");
                if (!string.IsNullOrEmpty(Console.ReadLine()))
                {
                    double expectedSalary = Convert.ToDouble(Console.ReadLine());
                    if (expectedSalary > 0)
                        careerProfile.ExpectedSalary = expectedSalary;
                    else
                        validations.Append("Please provide a decimal/integer value for  Expected Salary is missing(ex:4216.34).\n");
                }
                else
                {
                    validations.Append("Expected Salary is missing.\n");
                }

                //Job Role  
                Console.WriteLine("\nDifferent values for Job role:");
                List<string> jobRoleList = new List<string>();
                jobRoleList.Add(Constants.Constants.TESTING);
                jobRoleList.Add(Constants.Constants.DEVELOPMENT);
                jobRoleList.Add(Constants.Constants.PRODUCT_MANAGEMENT);
                jobRoleList.Add(Constants.Constants.PRODUCT_SUPPORT);
                jobRoleList.Add(Constants.Constants.DEPLOYMENT);
                jobRoleList.Add(Constants.Constants.MARKETING);               

                Utility.Utility.PrintListValues(jobRoleList);

                Console.Write("Select a value for Job Role(Ex. Select 1 for Testing.):");
                int jobRoleOutput = 0;
                bool isJobRoleHasValue = int.TryParse(Console.ReadLine(), out jobRoleOutput);
                string jobRoleValue = string.Empty;

                if (isJobRoleHasValue)
                {
                    switch (jobRoleOutput)
                    {
                        case (int)Enums.CurrentIndustry.HardwareAndNeworking1:
                            jobRoleValue = Constants.Constants.HARDWARE_NETWORKING;
                            break;
                        case (int)Enums.JobRole.Development:
                            jobRoleValue = Constants.Constants.DEVELOPMENT;
                            break;
                        case (int)Enums.JobRole.ProjectManagement:
                            jobRoleValue = Constants.Constants.PRODUCT_MANAGEMENT;
                            break;
                        case (int)Enums.JobRole.ProductSupport:
                            jobRoleValue = Constants.Constants.PRODUCT_SUPPORT;
                            break;
                        case (int)Enums.JobRole.Depolyment:
                            jobRoleValue = Constants.Constants.DEPLOYMENT;
                            break;
                       case (int)Enums.JobRole.Marketing:
                            jobRoleValue = Constants.Constants.MARKETING;
                            break;
                        default:
                            validations.Append("Unknown Value for Job Role is selected.\n");
                            break;
                    }
                    careerProfile.JobRole = jobRoleValue;
                }
                else
                {
                    validations.Append("Please select integer value for Job role (Ex.1 for Testing)\n");
                }

                //Error validations
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine($"\nError validations:\n{validations}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception errors:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"StackTrace Exception:{ex.StackTrace}");
            }
            return careerProfile;
        }
        //Print Candidate Career profile details
        public void PrintCareerProfileDetails(CareerProfile details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Career Profile Details:");
                Console.WriteLine("__________________________________");
                Console.WriteLine("Current Industry:{0}",details.CurrentIndustry);
                Console.WriteLine("Department:{0}",details.Department);
                Console.WriteLine("Job type:{0}",details.DesiredJobType);
                Console.WriteLine("Employment type:{0}",details.DesiredEmploymentType);
                Console.WriteLine("Preffered shift:{0}",details.PreferredShift);
                Console.WriteLine("Preffered work location:{0}",details.PreferredWorklocation);
                Console.WriteLine("Expected salary:{0}",details.ExpectedSalary);
                Console.WriteLine("Job role:{0}",details.JobRole);
               

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception errors:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"StackTrace Exception:{ex.StackTrace}");
            }

        }
    }
}
