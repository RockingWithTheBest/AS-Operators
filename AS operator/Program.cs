using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = "Hello";
            string value = obj as string;
            Console.WriteLine(value);
        }
    }
}
