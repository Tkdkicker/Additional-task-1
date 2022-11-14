using System;

namespace Additional_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You cannot vote");
            }

            else
            {
                Console.WriteLine("You can vote");
            }
        }
    }
}
