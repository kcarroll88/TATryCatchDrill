using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATryCatchDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(23);
            numbers.Add(14);
            numbers.Add(36);
            numbers.Add(47);
            Console.WriteLine("Choose a number.");
           
            try
            {
                int inputNum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i] / inputNum);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
            Console.WriteLine("We've emerged from the try catch!");
            Console.ReadLine();                      
        }
    }
}
