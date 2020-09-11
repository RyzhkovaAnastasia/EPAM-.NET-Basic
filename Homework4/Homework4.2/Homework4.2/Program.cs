using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Checking interface ICodeChecker implementation...");


            ProgramConverter[] arr = new ProgramConverter[]
            {
                new ProgramHelper(),
                new ProgramConverter(),
                new ProgramHelper(),
                new ProgramHelper(),
                new ProgramConverter()
            };
            foreach (var i in arr)
            {
                if (i is IСodeChecker)
                {
                    Console.WriteLine("----- implemented IСodeChecker");
                    if ((i as IСodeChecker).CheckCodeSyntax("",""))
                    {
                        Console.WriteLine(i.ConvertToCSharp(""));
                    }
                    else
                    {
                        Console.WriteLine(i.ConvertToVB(""));
                    }
                }
                else
                {
                    Console.WriteLine("---- NOT implemented IСodeChecker");
                    Console.WriteLine(i.ConvertToCSharp(""));
                    Console.WriteLine(i.ConvertToVB(""));
                }
            }
            Console.ReadKey();
        }
    }
}
 