using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace table_using_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Enter a number");
           int num1 = Convert.ToInt32(Console.ReadLine());

          int  i = 1; //Initialization
            //Check whether condition matches or not
            do
            {

               
                Console.WriteLine("{0} x {1} = {2}", num1, i,  num1 * i);
                i++; //Increment by one
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
