using System;

namespace IntroToCSharp
{
    class Program 
    {
        static void Main() 
        {
            Console.WriteLine("Welcome User! This program will determine the equivalent grade of the percentage that you will input as well as its description.");
            Console.WriteLine();
                
            Console.Write("Enter Your Grade in the Subject that you want to determine: ");
            string gradePercentage = Console.ReadLine();

            double grade = double.Parse(gradePercentage);

            if (gradePercentage == "D")
            {
                Console.WriteLine("Subject is Dropped.");
            }
            else if (gradePercentage == "W")
            {
                Console.WriteLine("Subject is Withdrawn.");
            }
            else if (gradePercentage == "Inc")
            {
                Console.WriteLine("Your Grade is Incomplete.");
            }
            else if (grade >= 97 && grade <= 100)
            {
                Console.WriteLine("Your Grade is 1.0 and its description is Excellent");
            }
            else if (grade >= 94 && grade <= 96)
            {
                Console.WriteLine("Your Grade is 1.25 and its description is Excellent");
            }
            else if (grade >= 91 && grade <= 93)
            {
                Console.WriteLine("Your Grade is 1.5 and its description is Very Good");
            }    
            else if (grade >= 88 && grade <= 90)
            {
                Console.WriteLine("Your Grade is 1.75 and its description is Very Good");
            }
            else if (grade >= 85 && grade <= 87)
            {
                Console.WriteLine("Your Grade is 2.0 and its description is Good");
            }
            else if (grade >= 82 && grade <= 84)
            {
                Console.WriteLine("Your Grade is 2.25 and its description is Good");
            }
            else if (grade >= 79 && grade <= 81)
            {
                Console.WriteLine("Your Grade is 2.5 and its description is Satisfactory");
            }
            else if (grade >= 76 && grade <= 78)
            {
                Console.WriteLine("Your Grade is 2.75 and its description is Satisfactory");
            }
            else if (grade == 75)
            {
                Console.WriteLine("Your Grade is 3.0 and its description is Passed");
            }
            else if (grade >= 65 && grade <= 74)
            {
                Console.WriteLine("Your Grade is 5.0 and its description is Failure");
            }
            else
            {
                Console.WriteLine("The input you enter is invalid, please try again");
            }
        }
    }
}
