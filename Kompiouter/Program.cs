
using System;
using System.Text;
using System.Threading.Tasks;

namespace Fagaki

{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Vale ton Proto arithmo:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Vale ton Deytero arithmo:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Vale ti praksi thes na kaneis(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);
                        break;
                    default:
                        Console.WriteLine("Lathos arithmos");
                        break;
                }
                Console.ReadLine();
                Console.Write("Thes na sinexiseis(nai/oxi):");
                value = Console.ReadLine();
            }
            while (value == "nai" || value == "NAI");
        }
    }

}
