using System;

namespace GettingUserInput // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");//prompt the user to enter their name
            string name = Console.ReadLine(); //now we want to store the values somewhere. get the line of text that the user enter as a string of characters.

            Console.WriteLine("Enter your age: ");//prompt the user to enter their age
            string age = Console.ReadLine(); //always the variable when the user enter 

            Console.WriteLine("Hello " + name + " you are " + age);


            //the value of the name will be print on the screen. We use Console.ReadLine() let the user answer the text. 



            //Console.ReadLine(); //What this line does it waits for the user to enter a line of text.
            //The program eseentially will pause.Once you enter a line of text and type enter it willl execute the program. 






        }





    }





}

/*
 
 WriteLine this is going to print out a text and go on to a new line.

 */