using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = new char[] { '0', '1', '2', '3', '4', '5', 'a', 'b', 'c' };
            // Create a list called numbers that will hold integers
            var numbers = new List<int>();
            // Create an string variable with an empty string initializer - name it str
            var str = "";
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            foreach(var character in arr)
            {

                try
                {
                    str = character.ToString();
                    var number = int.Parse(str);
                    numbers.Add(number);
                }
                catch
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }



            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
