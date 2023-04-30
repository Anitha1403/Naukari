using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Key skills
    /// </summary>
    public class KeySkillsService
    {
        /// <summary>
        /// Method that Reads Candidate key skils details from console screen
        /// </summary>
        /// <returns></returns>
        public List<string> ReadKeySkills()
        {           
            KeySkills skills = new KeySkills();
            List<string> skillsList = new List<string>();
            try
            {               
                StringBuilder validations = new StringBuilder();

                bool candidateChoice = false;
                do
                {                   
                    if (skillsList.Count == 0)
                        Console.WriteLine("\nProvide skill:\n");
                    else
                        Console.WriteLine("\nProvide one more Skill:");
                    Console.Write("Enter Skill name:");                  
                    string skill =Console.ReadLine(); 
                    string skillName = string.Empty;
                    if (!string.IsNullOrEmpty(skill) || !string.IsNullOrEmpty(skillName))
                    {                   
                        skillName = skill;
                        
                    }
                    else
                        validations.Append("Skill value is missing.\n");

                    Console.Write("Would you like to add one more Skill ?(true/false):");
                    string candidateWillingness = Console.ReadLine();

                    if (!string.IsNullOrEmpty(candidateWillingness))
                    {
                        if (candidateWillingness.ToLower() == "true" || candidateWillingness.ToLower() == "false")
                        {
                            bool willingness = Convert.ToBoolean(candidateWillingness);
                            if (willingness)
                                candidateChoice = true;
                            else
                                candidateChoice = false;
                        }
                        else
                        {
                            validations.Append("Give correct value for Candidate willingness(ex.True/False).");
                        }
                    }
                    else
                    {
                        validations.Append("Candidate willingness Value is missing.\n");
                    }
                    skillsList.Add(skillName);
                    Console.WriteLine();                   
                } while (candidateChoice == true);

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
            return skillsList;
        }
        /// <summary>
        /// Method that Prints Candidate key skils details to console screen
        /// </summary>
        /// <param name="keySkills"></param>
        public void PrintKeySkills(List<string> keySkills)
        {
            try
            {
                Console.WriteLine("\n\nCandidate Skills: ");
                Console.WriteLine("_________________________\n");
                int increment = 0;
                foreach (string skill in keySkills)
                {
                    increment++;
                    Console.WriteLine($"Skill {increment}: {skill}");
                }
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
