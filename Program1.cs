// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {

        void Ymn(int x, int y)
        {

            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }
        Console.WriteLine("Введиде значения x");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введиде значения y");
        int y = Convert.ToInt32(Console.ReadLine());
        Ymn(x, y);
    }
    
   

}







