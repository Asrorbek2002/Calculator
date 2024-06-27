using System;

namespace Calculator

{
    class Program 
    {
        static void Main()
        {
           Console.WriteLine("Enter numbers:");
           Console.Write("firstNumber: ");
                string firstUserValue = Console.ReadLine();
           Console.Write("secondNumber: ");
                string secondUserValue = Console.ReadLine();

           Console.WriteLine("Converting nambers in prograss....");
                decimal firstNumber = Convert.ToDecimal(firstUserValue);
                decimal secondNumber = Convert.ToDecimal(secondUserValue);

            Console.WriteLine("Here are your resultat...");
            Console.WriteLine($"{firstNumber} + {secondNumber} =  {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} =  {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} =  {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} =  {firstNumber / secondNumber }");
            Console.WriteLine($"{firstNumber} % {secondNumber} =  {firstNumber % secondNumber}");



         
           
                        
        }
    }
}
