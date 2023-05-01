using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Languages
    /// </summary>
    public class LanguagesService
    {
        /// <summary>
        ///  Method that Reads Candidate language details from console screen
        /// </summary>
        /// <returns></returns>
        public List<Language> ReadLanguage()
        {
            List<Language> languages = new List<Language>();
            StringBuilder validations = new StringBuilder();
            try
            {
                bool candidateChoice = false;
                do
                {
                    Language language = new Language();

                    if (languages.Count == 0)
                    {
                        Console.WriteLine("\nProvide Language Details:");
                        Console.WriteLine("_________________________\n");
                    }
                    else
                    {
                        Console.WriteLine("nProvide one more Language Details:");
                        Console.WriteLine("_________________________________\n");
                    }

                    //Language name
                    Console.Write("Enter Language Name:");
                    string languageName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(languageName))
                        language.LanguageName = languageName;
                    else
                        validations.Append("Language name is missing.\n");

                    //Language Proficiency
                    Console.WriteLine("Different Values for Language Proficiency:");
                    List<string> proficiencyList = new List<string>();
                    proficiencyList.Add(Constants.Constants.BEGINNER);
                    proficiencyList.Add(Constants.Constants.PROFICIENT);
                    proficiencyList.Add(Constants.Constants.EXPERT);

                    Utility.Utility.PrintListValues(proficiencyList);

                    Console.Write("Select Value for Language Proficiency Type(Ex: 1 for Beginner):");
                    string languageProficiency = Console.ReadLine();
                    if(!string.IsNullOrEmpty(languageProficiency))
                    {
                        int languageProficiencyOutput = 0;
                        bool islanguageProficiencyOutputValid = int.TryParse(languageProficiency, out languageProficiencyOutput);

                        string proficiencyValue = string.Empty;

                        if (islanguageProficiencyOutputValid)
                        {
                            switch (languageProficiencyOutput)
                            {
                                case (int)Enums.Proficiency.Beginner:
                                    proficiencyValue = Constants.Constants.BEGINNER;
                                    break;
                                case (int)Enums.Proficiency.Proficient:
                                    proficiencyValue = Constants.Constants.PROFICIENT;
                                    break;
                                case (int)Enums.Proficiency.Expert:
                                    proficiencyValue = Constants.Constants.EXPERT;
                                    break;
                                default:
                                    validations.Append("Unknown Value for Language Proficiency is selected.");
                                    break;
                            }
                            language.Proficiency = proficiencyValue;
                        }
                        else
                        {
                            validations.Append("Please select integer value for Language Proficiency (Ex: 1 for Beginner)\n");
                        }

                    }
                    else
                    {
                        validations.Append("Language Proficiency Value is missing.\n");
                    }   

                    //Read
                    Console.Write($"Can you Read {language.LanguageName} Language?(true/false):");
                    string languageReadValue = Console.ReadLine();
                    if (!string.IsNullOrEmpty(languageReadValue))
                    {
                        if (languageReadValue.ToLower() == "true" || languageReadValue.ToLower() == "false")
                        {
                            bool languageRead = Convert.ToBoolean(languageReadValue);
                            language.Read = languageRead;
                        }
                        else
                            validations.Append("Provide a value for Language Read(ex.true for Read).\n");
                    }
                    else
                        validations.Append("Language Read value is missing.\n");

                    //Write
                    Console.Write($"Can you Write {language.LanguageName} Language?(true/false):");
                    string languageWriteValue = Console.ReadLine();
                    if (!string.IsNullOrEmpty(languageWriteValue))
                    {
                        if (languageWriteValue.ToLower() == "true" || languageWriteValue.ToLower() == "false")
                        {
                            bool languageWrite = Convert.ToBoolean(languageWriteValue);
                            language.Write = languageWrite;
                        }
                        else
                            validations.Append("Provide a value for Language Write(ex.true for Read).\n");
                    }
                    else
                        validations.Append("Language Write value is missing.\n");

                    //Speak
                    Console.Write($"Can you Speak {language.LanguageName} Language?(true/false):");
                    string languageSpeakValue = Console.ReadLine();
                    if (!string.IsNullOrEmpty(languageSpeakValue))
                    {
                        if (languageSpeakValue.ToLower() == "true" || languageSpeakValue.ToLower() == "false")
                        {
                            bool languageSpeak = Convert.ToBoolean(languageSpeakValue);
                            language.Speak = languageSpeak;
                        }
                        else
                            validations.Append("Provide a value for Language Speak(ex.true for Read).\n");
                    }
                    else
                        validations.Append("Language Speak value is missing.\n");


                    Console.Write("Would you like to add one more Language ?(true/false):");
                    string candidateWillingness = Console.ReadLine();
                   
                    if (!string.IsNullOrEmpty(candidateWillingness))
                    {
                        if (candidateWillingness.ToLower() == "true" || candidateWillingness.ToLower() == "false")
                        {
                            bool willingness=Convert.ToBoolean(candidateWillingness);
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


                    languages.Add(language);

                    Console.WriteLine();

                    if (languages.Count == 5)
                    {
                        candidateChoice = false;
                        Console.WriteLine("\nYou cand only add maximum of 5 Languages\n");
                    }
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
            return languages;
        }
        /// <summary>
        /// Method that Prints Candidate language details to console screen
        /// </summary>
        /// <param name="languages"></param>
        public void PrintLanguages(List<Language> languages)
        {
            try
            {
                Console.WriteLine("\n\nCandidate Languages: ");
                Console.WriteLine("_________________________\n");
                int increment = 0;

                foreach (Language language in languages)
                {
                    increment++;
                    Console.WriteLine($"Language {increment}: {language.LanguageName}");
                    Console.WriteLine($"Proficiency: {language.Proficiency}");
                    if(language.Read)
                        Console.WriteLine($"Read:{Constants.Constants.ABLED_READ}");
                    else
                        Console.WriteLine($"Read:{Constants.Constants.NOT_ABLED_READ}");
                    if (language.Write)
                        Console.WriteLine($"Read:{Constants.Constants.ABLED_WRITE}");
                    else
                        Console.WriteLine($"Read:{Constants.Constants.NOT_ABLED_WRITE}");
                    if (language.Speak)
                        Console.WriteLine($"Read:{Constants.Constants.ABLED_SPEAK}");
                    else
                        Console.WriteLine($"Read:{Constants.Constants.NOT_ABLED_SPEAK}");
                    Console.WriteLine();
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
