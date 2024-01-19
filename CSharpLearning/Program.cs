// WAP to create a array of string having students name
// and print them
using System;

namespace StudentProgram {
    class Program {
        static void Main(string[] args)
        {
            Example1();
            Example1();
            Example1();
            Example1();
            Example1();
        }

        static void Example1() {
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