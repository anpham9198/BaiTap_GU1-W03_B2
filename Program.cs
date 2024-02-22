using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_GU1_W03
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("N = ");

            int n = int.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine(n + " khong phai nguyen to");
            }
            else
            {
                int bienDemUoc = 0;
                
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        bienDemUoc++;
                    }
                }

                if (bienDemUoc == 2)
                {
                    Console.WriteLine(n + " la nguyen to");
                }
                else
                {
                    Console.WriteLine(n + " khong la nguyen to");
                }

                Console.ReadKey();
            }
        }
    }
}
