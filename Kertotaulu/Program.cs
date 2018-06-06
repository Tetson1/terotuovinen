using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertotaulu
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Anna numero välillä 1-10");
            string input = Console.ReadLine();
            int luku;
            Int32.TryParse(input, out luku);

            
            try
            {
                int y = int.Parse(input);
                {
                    //if y > 0;

                    //return true
                    //        }
                    //else false
                }
            catch (FormatException ex)
            {
                Console.WriteLine("Anna uusi kokonaisluku");
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Anna uusi kokonaisluku");
            }
            
            for (int i = 1; i <= 10; i++)
            {
                int tulo = luku * i;
                Console.WriteLine("{0} * {1} = {2}", luku , i, tulo);
            }
            Console.WriteLine();

        }
    }
}
