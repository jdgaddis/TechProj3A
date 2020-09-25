/*
    Author: James Gaddis
    Date: 09/24/2020
    Comments: This C# console application asks the user to enter their name.
              Then using a method to print a message that says "Hello user's name (insert real name)".
*/

using System;

namespace TechProj3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Name.");
            // This variable will gather data from user input
            string name = Console.ReadLine();
            // Adds a line break
            Console.WriteLine();
            // Console's response
            Console.WriteLine("Hello" + " " + name);
        } // End of Main
    } // End of class
} // End of namespace

/* 
   Hello professor, I apologize if this was not how we were supposed to do this.
   I watched Clinton's video and was unable to get the custom methods to work in the console.
   This does however achieve the goal of the console responding with the users name.
*/
