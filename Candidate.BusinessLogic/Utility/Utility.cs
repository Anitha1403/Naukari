using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic.Utility
{
    public static class Utility
    {


        public static void PrintListValues(List<string> list)
        {
            try
            {
                int increment = 0;
                foreach (string item in list)
                {
                    increment++;
                    Console.WriteLine(increment + "." + item);
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
