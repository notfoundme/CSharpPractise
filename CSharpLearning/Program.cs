
using System;

namespace StudentProgram {
    class Program {
        static void Main(string[] args)
        {
            Example2();
        }

        static void Example2() {
            // WAP to create a array of money i earned this week
            // print average money i earned per day
            // monthly income based on average earning
            // yearly income based on average earning
            Double[] salary = new double[7] { 100, 50, 23, 20, 25, 24, 28 };
            Double sum = 0;
            foreach (Double item in salary) {
                sum += item;
            }

            Double average = sum / 7;
            Console.WriteLine("---------------------- The Hisab Machine ----------------------");
            Console.WriteLine("");
            Console.WriteLine("---------------------- The Average for each day ----------------------");
            Console.WriteLine(average);
            Console.WriteLine("---------------------- The Average for this month ----------------------");
            Console.WriteLine(average * 30);
            Console.WriteLine("---------------------- The Average for this year ----------------------");
            Console.WriteLine(average * 30 * 12);
            Console.WriteLine("---------------------- Total Earning ----------------------");
            Console.WriteLine(sum);
            Console.WriteLine("---------------------- Thank You ----------------------");
        }

        static void Example1() {
            // WAP to create a array of string having students name
            // and print them

            string[] students = new string[5] { "Sulav", "Garima", "upasana", "tesula", "udaya" };

            // using for each loop
            foreach (string x in students)
            {
                Console.WriteLine(x);
            }

            // using for loop
            for (int x = 0; x < students.Length; x++)
            {
                Console.WriteLine(students[x]);
            }

            int m = 0;
            while (m < students.Length)
            {
                Console.WriteLine(students[m]);

                m++;
            }

            Console.ReadKey();
        }
    }
}