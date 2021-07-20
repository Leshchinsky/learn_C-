using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");*/

            /*string Name = "Tom";
            Console.WriteLine(Name);*/

            /* var hello = "Hello world";
             var c = 20;
             int a = 10;
             ulong f = 20UL;
             Console.WriteLine(c.GetType().ToString());
             Console.WriteLine(hello.GetType().ToString());
             Console.WriteLine(a.GetType().ToString());
             Console.WriteLine(f.GetType().ToString());*/

           /* string name = "Tom";
            int age = 33;
            bool isEpmloyed = true;
            double weight = 78.65;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Works: {isEpmloyed}");
            Console.WriteLine($"Weigh: {weight}");

            Console.WriteLine($"Name: {name} Age: {age} Works: {isEpmloyed} Weight: {weight}");*/

            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            
            Console.WriteLine($"Name: {name}  Age: {age}  Height: {height}  Salary: {salary}$");
            




            Console.ReadKey();

        }
    }
}
