using System;

namespace youtube
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInputFirst, userInputSecond, userInputThird;
            int calculation = 0;
            int sum;

            //gathering user input of a number for calculation
            Console.WriteLine("Please enter first number to be calculated.");
            userInputFirst = Console.ReadLine();
            try{
                int userInputIntFirst = Int32.Parse(userInputFirst);
            } catch (FormatException e){
                Console.WriteLine(e.Message);
                System.Environment.Exit(0);
            }
            int firstInt = Int32.Parse(userInputFirst);
            Console.WriteLine("The first number to be calculated is " + userInputFirst + " Would you like to add, subtract, multiply, or divide?");

            //gather user input of operands for calculation
            userInputSecond = Console.ReadLine().ToLower();
            //validation of user input and assign variable for calculation
            if (userInputSecond.Contains("add")){
                calculation = 1;
            } else if (userInputSecond.Contains("subtract")){
                calculation = 2;
            } else if (userInputSecond.Contains("multiply")){
                calculation = 3;
            } else if (userInputSecond.Contains("divide")){
                calculation = 4;
            } else {
                Console.WriteLine("This input is not correct.");
                System.Environment.Exit(0);
            }

            //gathering user input of a number for calculation
            Console.WriteLine("You would like to " + userInputSecond + ". Please enter second number to be calculated.");
            userInputThird = Console.ReadLine();
            try{
                int userInputIntThird = Int32.Parse(userInputThird);
            } catch (FormatException e){
                Console.WriteLine(e.Message);
                System.Environment.Exit(0);
            }
            int thirdInt = Int32.Parse(userInputThird);

            //takes the values from earlier input for calculating
            Console.WriteLine("The sum of your calcualtions is: ");
            if (calculation == 1){
                sum = firstInt + thirdInt;
                Console.WriteLine(sum);
            } else if (calculation == 2){
                sum = firstInt - thirdInt;
                Console.WriteLine(sum);
            } else if (calculation == 3){
                sum = firstInt * thirdInt;
                Console.WriteLine(sum);
            } else if (calculation == 4){
                sum = firstInt / thirdInt;
                Console.WriteLine(sum);
            } else {
                Console.WriteLine("Your input is not valid.");
                System.Environment.Exit(0);
            }
        }
    }
}
