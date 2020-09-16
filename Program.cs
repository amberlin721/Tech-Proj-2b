using System;

// Author: Xiao Lin
// Date: 09/15/2020
// Description: this C# application code demonstrates the use of conditional statement after getting input from users

namespace Tech_Proj_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input 
            Console.WriteLine("Please enter an interger value of the grade that you expect to get for ISM4300 class");

            // Use he try and catch block to validate user input
            // if the user provide wrong input, the catch block will handle the eror and a message will be displayed.

            try 
            {
                // This variable will gather the user input
                int grade;
                grade = int.Parse(Console.ReadLine());

                // Display letter grade: A B C D F
                if (grade <= 59) 
                    // this variables will diaplay letter grade F
                {
                    Console.WriteLine("Your letter grade for ISM4300 is F");
                }

                else if ((grade >= 60) && (grade <= 79)) 
                    //this variable will diaplay letter grade D
                {
                    Console.WriteLine("Your letter grade for ISM4300 is D");
                }

                else if ((grade >= 70) && (grade <= 89)) 
                    // this variable will display letter grade C
                {
                    Console.WriteLine("Your letter grade for ISM4300 is C");
                }

                else if ((grade >= 80) && (grade <= 89)) 
                    //this variable will display letter grade B
                {
                    Console.WriteLine("Your letter grade for ISM4300 is B");
                }

                else if ((grade >= 90) && (grade <= 100)) 
                    // this variable will display letter grade A
                { 
                    Console.WriteLine("Your letter grade for ISM4300 is A");
                }
            } //end of try


            catch
            {
                Console.WriteLine("Please enter an integer value of your expected grade next time"); //displayed when the user enter valid input
                Console.WriteLine("Press any key to exit the program and try again"); // close the window
                Console.ReadKey(true);
            } // end of catch


        } //end of main
    } // end of class
} // end of namespace
