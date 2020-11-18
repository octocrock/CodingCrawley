using System;

namespace mycalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user input
            Console.WriteLine("Enter 2 or more numbers, separated by a comma (e.g. 2,4,6):");  

            // Take the input values into a string variable, trim that value, to make sure there are no spaces either end of it
            var numbers = Console.ReadLine().Trim();  

            SumAllValues(numbers);

            Console.ReadKey();  
        }

        static int SumAllValues(string numbers){
            
            // Put those values into an array 
            var numbersArray = numbers.Split(",");

            // Set the initial values of the result and the input value check flag
            int result = 0;
            bool inputValuesAreValid = true;

            // Loop through the array 
            foreach (var numbersArrayItem in numbersArray)
            {
                int wholeNumber;
                
                // Test to see if the number is a valid integer, if it isn't "numberIsAnInteger" will = false
                bool numberIsAnInteger = Int32.TryParse(numbersArrayItem, out wholeNumber);

                if (numberIsAnInteger){
                    // If the current number is an integer then add it on to the current value of "result"
                    result += wholeNumber;
                } else {
                    // If the current number is NOT an integer, set the flag to show we have invalid values
                    inputValuesAreValid = false;

                    // and then break out of the foreach loop, there is no point continuing
                    break;
                }          
            }

            if (inputValuesAreValid){
                // If all the input values are valid, write a message back to the console with the result
                Console.WriteLine("The result is {0}.   Press any key to end program.", result);  
            } else {                
                // If one or more of the input values is invalid, let the user know. 
                Console.WriteLine("Not all values are integers!");
            }
        }
    }
}
