using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_Sister_0074
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("========== Irfan Nurahman || 18.11.0074 ==========");
            Console.WriteLine("  mulai melakukan pekerjaan");
            Console.WriteLine("==================================================");

            non_Thread tid1 = new non_Thread();

            tid1.cuci_baju();
            tid1.strika();


            Console.WriteLine("==================================================");
            Console.WriteLine("  Selesai........!! ");
            Console.WriteLine("========== Irfan Nurahman || 18.11.0074 ==========");
            Console.ReadLine();
        }

        public class non_Thread
        {

            public void cuci_baju()
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("cuci baju ke {0}", i);
                }
            }
            public void strika()
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Setrika ke {0}", i);
                }
            }
        }
    }
}
