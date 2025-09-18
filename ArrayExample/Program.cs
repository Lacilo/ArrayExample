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
        static void Main(string[] args)                                 // FŐPROGRAM
        {
            // LISTA LÉTREHOZÁSA
            int[] nums = new int[5];                                    // 5 ELEM HOSSZÚ LISTA INICIALIZÁLÁSA


            // AZ ELEMEK BEKÉRÉSE EGYESÉVEL
            //nums[0] = int.Parse(Console.ReadLine());


            // AZ ADATOK BEKÉRÉSE CIKLUSSAL
            for (int i = 0; i < 5; i++)                                 // 5 SZÁMOT BEKÉRŐ CIKLUS
            {
                Console.Write($"Kérem a(z) {i + 1}. elemet \\-$ ");     // LISTA ELEMEINEK BEKÉRÉSE
                nums[i] = int.Parse(Console.ReadLine());                // ELTÁROLÁS A nums LISTÁBA
            }


            // AZ ADATOK KIÍRÁSA CIKLUSSAL
            foreach (int num in nums)                                   // VÉGIGLÉPKEDÉS A nums LISTÁN
            {
                Console.Write(num + ", ");                              // SZÁMOK EGY SORBA VALÓ KIÍRÁSA
            }

        }
    }
}
