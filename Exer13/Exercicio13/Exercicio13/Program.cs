using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            
             
            Console.WriteLine("Qual tabuada vc gostaria de ver?");
            int tabuada = Convert.ToInt16 (Console.ReadLine());

            for(int  i = 1; i<=10 ; i++)
            {

                Console.WriteLine(tabuada + "x" + i + " = " + tabuada*i);
            }
        

        }
    }
}
