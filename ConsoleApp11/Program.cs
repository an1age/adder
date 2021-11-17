using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string userAnswer = "";

            do
            {
                try
                {
                    Console.Write("Введите число: ");
                    userAnswer = Console.ReadLine();

                    result += Convert.ToInt32(userAnswer);
                    Console.WriteLine($"Текущая сумма: {result}\n");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\n");
                }
            }
            while (userAnswer != "exit");

        }
    }
}
