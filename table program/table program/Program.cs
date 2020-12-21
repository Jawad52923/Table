using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace table_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Write the table num");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num +"x"+ i +"="+ i*num);
               // Console.WriteLine("{0}*{1}={2}", num,i,i*num );
          
            }
        }
    }
}
