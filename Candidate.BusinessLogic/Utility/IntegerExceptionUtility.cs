using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic.Utility
{
    public static class IntegerExceptionUtility
    {
        public static bool IsNumeric(string inputValue)
        {
            bool boolValue = false;
           
            Regex rgx = new Regex(@"^[A-Za-z]+\d+.*$");
               
            if (rgx.IsMatch(inputValue))
                boolValue = false;
            else 
                boolValue = true;          
          
             return boolValue;       

        }
    }
}
