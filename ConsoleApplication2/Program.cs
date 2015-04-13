using System;
using System.Diagnostics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int число=50;
            int число2=80;
            int сумма;
            //сумма = число.ToString();

           
            сумма = число + число2;
            Console.WriteLine(сумма);

         

            if (args == null) throw new ArgumentNullException("args");
            int var2 = 10;
            int p,a=10, b=20;
            //p = a + b;
            p = a + b;

            var var1 = var2 >> 1;
         //   string resultString = (var1 < 10) ? "Меньше 10" : "Больше или равно 10";
            Console.Write("Color console ");
            Console.ForegroundColor = ConsoleColor.Gray;
         //   Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), System.ConsoleColor.DarkMagenta);
            Console.WriteLine("This is background color ");
          
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("a+b={0}",p);
            Console.Clear();
            Console.WriteLine("Hello ");

            Debug.WriteLine(var1);
            Console.ReadLine();



        }
    }
}
