using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27112019_c_in_21Tagen
{
    class Program
    {
        enum Jahr
        {
            Jänner,
            Februar

        }

        Klasse1 obj = new Klasse1();

        int operand = Convert.ToInt32(Console.ReadLine());
        string text = "text";
        static void Main(string[] args)
        {
            double temp = 0;
            Convert.ToString(temp);


            Jahr test = Jahr.Februar;


            if (test == Jahr.Februar)
            {

            }
        }

        static int Test(Jahr heuer)
        {
            if (heuer == Jahr.Februar) return 1;
            else return 0;                
        }
    }

    internal class Klasse1
    {
        public void Test()
        {

        }
        static void Main()
        {
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                
            }
            
        }
    }

    
}
