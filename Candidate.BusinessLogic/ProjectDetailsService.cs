using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds that services of Project details
    /// </summary>
    public class ProjectDetailsService
    {
       /// <summary>
       /// Method that Reads Candidate Project details from console screen
       /// </summary>
       /// <returns></returns>
        public ProjectDetails ReadProjectDetails()
        {
            ProjectDetails projectDetails = new ProjectDetails();
            StringBuilder validations = new StringBuilder();
            Regex rgx = new Regex(@"^[A-Za-z]+\d+.*$");

            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Project Details:\n");

                //Project title
                Console.Write("Enter Project title:");
                string projectTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(projectTitle))
                    projectDetails.ProjectTitle = projectTitle;
                else
                    validations.Append("Candidate Project Title is missing.\n");

                //Tag with Employment
                Console.WriteLine("\nDifferent values for TagWithEmployment:");
                List<string> tagWithEmploymentList = new List<string>();
                tagWithEmploymentList.Add(Constants.Constants.PHD);
                tagWithEmploymentList.Add(Constants.Constants.GRADUATION);
                tagWithEmploymentList.Add(Constants.Constants.PREVIOUS_EMPLOYMENT);

                Utility.Utility.PrintListValues(tagWithEmploymentList);

                Console.Write("Select a value for tagWithEmployment(Ex. Select 1 for Phd.):");
                int tagWithEmploymentOutput = 0;
                bool istagWithEmploymentHasValue = int.TryParse(Console.ReadLine(), out tagWithEmploymentOutput);
                string tagWithEmploymentValue = string.Empty;

                if (istagWithEmploymentHasValue)
                {
                    switch (tagWithEmploymentOutput)
                    {
                        case (int)Enums.TagwithEmployment.Phd:
                            tagWithEmploymentValue = Constants.Constants.PHD;
                            break;
                        case (int)Enums.TagwithEmployment.Grduation:
                            tagWithEmploymentValue = Constants.Constants.GRADUATION;
                            break;
                        case (int)Enums.TagwithEmployment.PreviousEmployement:
                            tagWithEmploymentValue = Constants.Constants.PREVIOUS_EMPLOYMENT;
                            break;
                        default:
                            validations.Append("Unknown Value for TagWithEmployment is selected.\n");
                            break;
                    }
                    projectDetails.TagwithEmployment = tagWithEmploymentValue;
                }
                else
                {
                    validations.Append("Please select integer value for TagWithEmployment(Ex.1 for Phd)\n");
                }

                //Client
                Console.Write("Enter Client Name:");
                string client = Console.ReadLine();
                if (!string.IsNullOrEmpty(client))
                    projectDetails.Client = client;
                else
                    validations.Append("Candidate client name is missing.\n");

                //Project status
                Console.WriteLine("\nDifferent values for Project status:");
                List<string> projectStatusList = new List<string>();
                projectStatusList.Add(Constants.Constants.IN_PROGRESS);
                projectStatusList.Add(Constants.Constants.COMPLETED);

                Utility.Utility.PrintListValues(projectStatusList);

                Console.Write("Select a value for Project Status(Ex. Select 1 for InProgress.):");
                int projectStausOutput = 0;
                bool isProjectStausHasValue = int.TryParse(Console.ReadLine(), out projectStausOutput);
                string projectSatusValue = string.Empty;

                if (isProjectStausHasValue)
                {
                    switch (projectStausOutput)
                    {
                        case (int)Enums.ProjectStatus.InProgress:
                            projectSatusValue = Constants.Constants.IN_PROGRESS;
                            break;
                        case (int)Enums.ProjectStatus.Completed:
                            projectSatusValue = Constants.Constants.COMPLETED;
                            break;
                        default:
                            validations.Append("Unknown Value for Project status is selected.\n");
                            break;
                    }
                    projectDetails.ProjectStatus = projectSatusValue;
                }
                else
                {
                    validations.Append("Please select integer value for project Satus (Ex.1 for InProgress)\n");
                }

                //Work From Year
                Console.Write("Enter Project work starts from year:");
                string workFromYear = Console.ReadLine();
                if (!string.IsNullOrEmpty(workFromYear))
                    projectDetails.WorkFromYear = workFromYear;
                else
                    validations.Append("Candidate workFromYear is missing.\n");
                //WorkFromMonth
                Console.Write("Enter Project work starts from month:");
                string WorkFromMonth = Console.ReadLine();
                if (!string.IsNullOrEmpty(WorkFromMonth))
                    projectDetails.WorkFromMonth = WorkFromMonth;
                else
                    validations.Append("Candidate WorkFromMonth is missing.\n");
                //Project Description
                Console.Write("Enter Project Description (minimum 20 characters):");
                string projectDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(projectDescription))
                    if (projectDescription.Length >= 20)
                        projectDetails.ProjectDescription = projectDescription;
                    else
                        validations.Append("Provide Project Description(minimum 20 characters).\n");
                else
                    validations.Append("Candidate Project Description is missing.\n");

                //Location
                Console.Write("Enter Project Location:");
                string projectLocation = Console.ReadLine();
                if (!string.IsNullOrEmpty(projectLocation))
                    projectDetails.ProjectLocation = projectLocation;
                else
                    validations.Append("Candidate location is missing.\n");

                //Project site
                Console.WriteLine("\nDifferent values for Project site:");
                List<string> projectSiteList = new List<string>();
                projectSiteList.Add(Constants.Constants.ONSITE);
                projectSiteList.Add(Constants.Constants.OFFSITE);

                Utility.Utility.PrintListValues(projectSiteList);

                Console.Write("Select a value for Project Status(Ex. Select 1 for Off Site.):");
                int projectSiteOutput = 0;
                bool isProjectSiteHasValue = int.TryParse(Console.ReadLine(), out projectSiteOutput);
                string projectSiteValue = string.Empty;

                if (isProjectSiteHasValue)
                {
                    switch (projectSiteOutput)
                    {
                        case (int)Enums.ProjectSite.offsite:
                            projectSiteValue = Constants.Constants.OFFSITE;
                            break;
                        case (int)Enums.ProjectSite.Onsite:
                            projectSiteValue = Constants.Constants.ONSITE;
                            break;
                        default:
                            validations.Append("Unknown Value for Project site is selected.\n");
                            break;
                    }
                    projectDetails.ProjectSite = projectSiteValue;
                }
                else
                {
                    validations.Append("Please select integer value for project site (Ex.1 for Off Site)\n");
                }

                //EmploymentNature
                Console.WriteLine("\nDifferent values for Employment nature:");
                List<string> employmentNatureList = new List<string>();
                employmentNatureList.Add(Constants.Constants.FULLTIME);
                employmentNatureList.Add(Constants.Constants.PARTTIME);
                employmentNatureList.Add(Constants.Constants.CONTRACTUAL);

                Utility.Utility.PrintListValues(employmentNatureList);

                Console.Write("Select a value for employment nature(Ex. Select 1 for Full time.):");
                int employmentNatureOutput = 0;
                bool isEmploymentNatureHasValue = int.TryParse(Console.ReadLine(), out employmentNatureOutput);
                string employmentNatureValue = string.Empty;

                if (isEmploymentNatureHasValue)
                {
                    switch (employmentNatureOutput)
                    {
                        case (int)Enums.EmploymentNature.FullTime:
                            employmentNatureValue = Constants.Constants.FULLTIME;
                            break;
                        case (int)Enums.EmploymentNature.PartTime:
                            employmentNatureValue = Constants.Constants.PARTTIME;
                            break;
                        case (int)Enums.EmploymentNature.Contractual:
                            employmentNatureValue = Constants.Constants.CONTRACTUAL;
                            break;
                        default:
                            validations.Append("Unknown Value for Employment Nature is selected.\n");
                            break;
                    }
                    projectDetails.EmploymentNature = employmentNatureValue;
                }
                else
                {
                    validations.Append("Please select integer value for Employment nature (Ex.1 for full time)\n");
                }

                //team size
                Console.Write("Enter Team Size:"); 
                string strTeamSize = Console.ReadLine();                
                
                if (!string.IsNullOrEmpty(strTeamSize))
                {
                    if (rgx.IsMatch(strTeamSize))
                    {
                        string teamSizeValue = strTeamSize;

                    }
                    else if (Regex.IsMatch(strTeamSize, @"^\d+$"))
                    {
                        int teamSize = int.Parse(strTeamSize);
                        projectDetails.TeamSize = teamSize;
                    }
                    else
                    {
                        validations.Append("Provide integer value for team size.(ex.3).\n");
                    }
                }
                else
                {
                    validations.Append("Project team size value is missing.\n");
                }

                //Role
                Console.WriteLine("\nDifferent values for Role:");
                List<string> roleList = new List<string>();
                roleList.Add(Constants.Constants.TEST_ENGINEER);
                roleList.Add(Constants.Constants.QA_ARCHITECT);
                roleList.Add(Constants.Constants.TECH_LEAD);
                roleList.Add(Constants.Constants.PROJECT_MANAGER);
                roleList.Add(Constants.Constants.DEVELOPER);
                roleList.Add(Constants.Constants.SUPPORT);

                Utility.Utility.PrintListValues(roleList);

                Console.Write("Select a value for Role(Ex. Select 1 for Test Engineer.):");
                int roleOutput = 0;
                bool isRoleHasValue = int.TryParse(Console.ReadLine(), out roleOutput);
                string roleValue = string.Empty;

                if (isRoleHasValue)
                {
                    switch (roleOutput)
                    {
                        case (int)Enums.Role.TestEngineer:
                            roleValue = Constants.Constants.TEST_ENGINEER;
                            break;
                        case (int)Enums.Role.QAArchitect:
                            roleValue = Constants.Constants.QA_ARCHITECT;
                            break;
                        case (int)Enums.Role.TechLead:
                            roleValue = Constants.Constants.TECH_LEAD;
                            break;
                        case (int)Enums.Role.ProjectManager:
                            roleValue = Constants.Constants.PROJECT_MANAGER;
                            break;
                        case (int)Enums.Role.Developer:
                            roleValue = Constants.Constants.DEVELOPER;
                            break;
                        case (int)Enums.Role.Support:
                            roleValue = Constants.Constants.SUPPORT;
                            break;
                        default:
                            validations.Append("Unknown Value for Role is selected.\n");
                            break;
                    }
                    projectDetails.Role = roleValue;
                }
                else
                {
                    validations.Append("Please select integer value for Role(Ex.1 for Test Engineer)\n");
                }

                //Role Description
                Console.Write("Enter Role Description (minimum 20 characters):");
                string roleDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(roleDescription))
                    if (roleDescription.Length >= 20)
                        projectDetails.RoleDescription = roleDescription;
                    else
                        validations.Append("Enter Role Description (minimum 20 characters).\n");
                else
                    validations.Append("Candidate Role Description is missing.\n");


                //Skill used
                Console.Write("Enter Skill Used:");
                string skillUsed = Console.ReadLine();
                if (!string.IsNullOrEmpty(skillUsed))
                    projectDetails.SkillsUsed = skillUsed;
                else
                    validations.Append("Candidate skill used is missing.\n");

                //Error validations
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"Error validations:\n{validations}");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception errors:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"StackTrace Exception:{ex.StackTrace}");
            }
            return projectDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Project details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintProjectDetails(ProjectDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Project Details:");
                Console.WriteLine("____________________________");
                Console.WriteLine("Project Title:{0}", details.ProjectTitle);
                Console.WriteLine("Tag with employment:{0}", details.TagwithEmployment);
                Console.WriteLine("Client:{0}", details.Client);
                Console.WriteLine("Project status:{0}", details.ProjectStatus);
                Console.WriteLine("Work from year:{0}", details.WorkFromYear);
                Console.WriteLine("Work from month:{0}", details.WorkFromMonth);
                Console.WriteLine("Project description:{0}", details.ProjectDescription);
                Console.WriteLine("Projec location:{0}", details.ProjectLocation);
                Console.WriteLine("Project site:{0}", details.ProjectSite);
                Console.WriteLine("Employment nature:{0}", details.EmploymentNature);
                Console.WriteLine("Team size:{0}", details.TeamSize);
                Console.WriteLine("Role:{0}", details.Role);
                Console.WriteLine("Role Description:{0}", details.RoleDescription);
                Console.WriteLine("Skill used:{0}", details.SkillsUsed);

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
