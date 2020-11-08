using System;

namespace mycalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user input
            Console.WriteLine("Enter first number:");  

            // This line take the value and converts it to an integer
            int input_1 = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Enter second number");  
            int input_2 = Convert.ToInt32(Console.ReadLine());  

            // Set the result value to a starting value of zero
            int result = 0;  


            // If the value held in either "input_1" or "input_2"is less than zero, write a message to the console 
            if (input_1 < 0 || input_2 < 0) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter a number greater than zero!  Press any key to end program.", result);  

                Console.ForegroundColor = ConsoleColor.White;

            } else {
            
                // Call a function to add the two values together, put the output of the function into the result variable
                result = Addition(input_1, input_2);  
                
                Console.ForegroundColor = ConsoleColor.Green;
                // Write a message back to the console with the result
                Console.WriteLine("The result is {0}.   Press any key to end program.", result);  

                Console.ForegroundColor = ConsoleColor.White;
            }
            
            Console.ReadKey();  
        }

        static int Addition(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
