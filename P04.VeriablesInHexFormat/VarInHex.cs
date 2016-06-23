using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.VeriablesInHexFormat
{
    class VarInHex
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int num1 = Convert.ToInt32(num, 16);

            Console.WriteLine(num1);
        }
    }
}
