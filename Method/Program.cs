/*
    Author: Aaron Davila
    Date: 09/18/2019
    Class: ISM 4300
    Description: This will demonstrate the use of a method after getting input from a user and being able to pull the method into the application
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            abc(); //Setting up/creating and naming the abc method 
            Console.ReadKey(true);
        }
        private static void abc()  // this will allow the method to be called 
        {
            Console.WriteLine("Please type in your name: "); //allowing the user to put input
            string input = Console.ReadLine();
            Console.WriteLine("Hi " + input + "!"); //This helps grab the users input and be seen
            //new change for upload 
            Console.ReadKey(); //Creating a Readkey for the results to be shown for the input
        }
    }
}
