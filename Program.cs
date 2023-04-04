using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            while(true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 0) break;
                if(choice == 1)
                {
                    Console.WriteLine("Draw the triangle");
                    for(int i=6 ; i>0 ; i--)
                    {
                        for(int j=i ; j>0 ; j--)
                        {
                            Console.Write("* ");
                        }
                        Console.Write("\n");
                    }
                }
                else if(choice == 2)
                {
                    Console.WriteLine("Draw the square");
                    for(int i=0 ; i<6 ; i++)
                    {
                        Console.WriteLine("* * * * * *");
                    }
                }
                else
                {
                    Console.WriteLine("Draw the rectangle");
                    for(int i=0 ; i<3 ; i++)
                    {
                        Console.WriteLine("* * * * * *");
                    }
                }
            }
        }
    }
}