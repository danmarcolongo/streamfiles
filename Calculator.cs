using System;

namespace csharp
{
    class Calculator{
        static void Main(string[] args){
            String userInputFir, userInputSec, userInputThir;
            String messageUser = "Thank you for selecting. Please enter a number to calculate";
            int calculation = 0;
            int sum;

            //Gather input from the user and check if number is the datatype used
            Console.WriteLine("Please type a number");
            userInputFir = Console.ReadLine();
            try{
                int numVal1 = Int32.Parse(userInputFir);
                Console.WriteLine("The first number to be calculated is " + userInputFir);
            }
            catch (FormatException e){
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

            //takes input from the user and creates a variable for use in calculation
            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
            userInputSec = Console.ReadLine();
            userInputSec = userInputSec.ToLower();
            if (userInputSec.Contains("add")){
                Console.WriteLine(messageUser);
                calculation = 1;
            } else if (userInputSec.Contains("subtract")){
                Console.WriteLine(messageUser);
                calculation = 2;
            } else if (userInputSec.Contains("multiply")){
                Console.WriteLine(messageUser);
                calculation = 3;
            } else if (userInputSec.Contains("divide")){
                Console.WriteLine(messageUser);
                calculation = 4;
            } else {
                Console.WriteLine("That is not a recognized input");
                Environment.Exit(0);
            }

            //Gather input from the user and check if number is the datatype used
            userInputThir = Console.ReadLine();
            try{
                int numVal2 = Int32.Parse(userInputThir);
                Console.WriteLine("The second number to be calculated is " + userInputThir);
            }
            catch (FormatException e){
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

            //takes data entered by user and creates a sum based on user input from prior steps
            if (calculation.Equals(1)){
                Console.WriteLine(userInputFir + " + " + userInputThir + " = ");
                int numVal1 = Int32.Parse(userInputFir);
                int numVal2 = Int32.Parse(userInputThir);
                sum = numVal1 + numVal2;
                Console.Write(sum);
            } else if (calculation.Equals(2)){
                Console.WriteLine(userInputFir + " - " + userInputThir + " = ");
                int numVal1 = Int32.Parse(userInputFir);
                int numVal2 = Int32.Parse(userInputThir);
                sum = numVal1 - numVal2;
                Console.Write(sum);
            } else if (calculation.Equals(3)){
                Console.WriteLine(userInputFir + " * " + userInputThir + " = ");
                int numVal1 = Int32.Parse(userInputFir);
                int numVal2 = Int32.Parse(userInputThir);
                sum = numVal1 * numVal2;
                Console.Write(sum);
            } else if (calculation.Equals(4)){
                Console.WriteLine(userInputFir + " / " + userInputThir + " = ");
                int numVal1 = Int32.Parse(userInputFir);
                int numVal2 = Int32.Parse(userInputThir);
                sum = numVal1 / numVal2;
                Console.WriteLine(sum);
            } else {
                Console.WriteLine("An error has occured in the final step");
                Environment.Exit(0);
            }
        }
    }
}
