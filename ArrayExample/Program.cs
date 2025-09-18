using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];

            // AZ ELEMEK BEKÉRÉSE EGYESÉVEL
            //nums[0] = int.Parse(Console.ReadLine());


            // AZ ADATOK BEKÉRÉSE CIKLUSSAL
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. elemet \\-$ ");
                nums[i] = int.Parse(Console.ReadLine());
            }


            // AZ ADATOK KIÍRÁSA CIKLUSSAL
            foreach (int num in nums)
            {
                Console.Write(num + ", ");
            }

        }
    }
}
