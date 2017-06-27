using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 9; //nombre de tentatives
          
            DateTime startDate = DateTime.Now;
            Pioche toto = new Pioche("lemot");
            Console.WriteLine(toto);
            
            
            while (!toto.MotTrouve() && i > 0)
            {
                toto.LettreTrouve(Console.ReadKey().KeyChar);
                Console.WriteLine("\n"+toto);
                i--;
            }

            if(toto.MotTrouve())
            {
                TimeSpan ts = DateTime.Now - startDate;
               Console.WriteLine( "gagné en " + ts.ToString(@"ss\:fff")+ " s");
                
            }
            else
            {
                TimeSpan ts = DateTime.Now - startDate;
                Console.WriteLine("perdu en " + ts.ToString(@"ss\:fff") + " s");
            }



            Console.ReadLine();
        }


    }
}
