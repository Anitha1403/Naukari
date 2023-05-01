using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate.BusinessLogic
{
    /// <summary>
    /// Class holds services of Address details
    /// </summary>
    public class AddressDetailsService
    {
        /// <summary>
        /// Method that Reads Candidate Address details from console screen
        /// </summary>
        /// <returns></returns>
        public AddressDetails ReadAddressDetails()
        {
            AddressDetails addressDetails = new AddressDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("\n\nProvide Candidate Address Details");
                Console.WriteLine("______________________________________");
                Console.WriteLine();
                //Address Type
                Console.WriteLine("Different Address Types:");
                List<string> addressTypeList = new List<string>();
                addressTypeList.Add(Constants.Constants.PERMANENT_ADDRESS);
                addressTypeList.Add(Constants.Constants.CURRENT_ADDRESS);

                Utility.Utility.PrintListValues(addressTypeList);

                Console.Write("Select a integer value for Address Type (ex.1 for Permanent type):");
                int addressTypeOutput = 0;
                bool isAddressTypeHasValue = int.TryParse(Console.ReadLine(), out addressTypeOutput);
                string addressTypeValue = string.Empty;

                if (isAddressTypeHasValue)
                {
                    switch (addressTypeOutput)
                    {
                        case (int)Enums.AddressType.PermanentAddress:
                            addressTypeValue = Constants.Constants.PERMANENT_ADDRESS;
                            break;
                        case (int)Enums.AddressType.CurrentAddress:
                            addressTypeValue = Constants.Constants.CURRENT_ADDRESS;
                            break;
                        default:
                            validations.Append("Unknown Value for AddressType is selected.\n");
                            break;
                    }
                    addressDetails.AddressType = addressTypeValue;
                }
                else
                    validations.Append("Please select integer value for addressType(Ex.2 for Current address).\n");              
                //Read BuildingNumber
                Console.Write("Enter Building Number:");
                string buildingNumber=Console.ReadLine();
                if (!string.IsNullOrEmpty(buildingNumber))
                    addressDetails.BuildingNumber = buildingNumber;
                else
                    validations.Append("Building number is missing.\n");
                //Read HouseNumber
                Console.Write("Enter House Number:");
                string houseNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(houseNumber))
                    addressDetails.HouseNumber = houseNumber;
                else
                    validations.Append("House number is missing.\n");
                //Read Street Name
                Console.Write("Enter street name:");
                string street = Console.ReadLine();
                if (!string.IsNullOrEmpty(street))
                    addressDetails.Street = street;
                else
                    validations.Append("Street field value is missing.\n");
                //Read LandMark
                Console.Write("Enter Land Mark:");
                string landMark = Console.ReadLine();
                if (!string.IsNullOrEmpty(landMark))
                    addressDetails.LandMark = landMark;
                else
                    validations.Append("Land Mark value is missing.\n");
                //Read LandMark
                Console.Write("Enter City Name:");
                string city = Console.ReadLine();
                if (!string.IsNullOrEmpty(city))
                    addressDetails.City = city;
                else
                    validations.Append("City value is missing.\n");
                //Read State name
                Console.Write("Enter State name:");
                string state = Console.ReadLine();
                if (!string.IsNullOrEmpty(state))
                    addressDetails.State = state;
                else
                    validations.Append("State value is missing.\n");
                //Read country name
                Console.Write("Enter Country Name:");
                string country = Console.ReadLine();
                if (!string.IsNullOrEmpty(country))
                    addressDetails.Country = country;
                else
                    validations.Append("Country value is missing.\n");
                //Read PostalCode
                Console.Write("Enter Postal Code:");
                string postalCode = Console.ReadLine();
                if (!string.IsNullOrEmpty(postalCode))
                    addressDetails.PostalCode = postalCode;
                else
                    validations.Append("PostalCode value is missing.\n");

                //Error Validations
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.Write("\n\n");
                    Console.WriteLine($"Validation Errors:\n{validations}");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception Message:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"Exception StackTrace:{ex.StackTrace}");
            }

            return addressDetails;
        }
        /// <summary>
        /// Method that Prints Candidate Address details to console screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintAddressDetails(AddressDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Candidate Address Details:");
                Console.WriteLine("__________________________\n");
                Console.WriteLine($"Address Type:{details.AddressType}");
                Console.WriteLine($"Building number:{details.BuildingNumber}");
                Console.WriteLine($"House number:{details.HouseNumber}");
                Console.WriteLine($"Street:{details.Street}");
                Console.WriteLine($"LandMark:{details.LandMark}");
                Console.WriteLine($"City:{details.City}");
                Console.WriteLine($"State:{details.State}");
                Console.WriteLine($"Country:{details.Country}");
                Console.WriteLine($"Postal code:{details.PostalCode}");                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Message:{ex.Message}");
                Console.WriteLine();
                Console.WriteLine($"Exception StackTrace:{ex.StackTrace}");
            }
        }
    }
}
