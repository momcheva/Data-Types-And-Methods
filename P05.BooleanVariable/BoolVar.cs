using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.BooleanVariable
{
    class BoolVar
    {
        static void Main(string[] args)
        {
            
                string value = Console.ReadLine();

                bool isTrue = Convert.ToBoolean(value);

                if (isTrue)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            
        }
    }
}
