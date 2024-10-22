// See https://aka.ms/new-console-template for more information

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        // Initialize Variable
        int num1;
        int num2;

        string? answer;
        
        int result = 0;
        
        Console.WriteLine("Hello Welcome to Calculator Program!");
        
        Console.WriteLine("Please enter your first number: " );
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Please enter your second number: " );
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("What type of operation do you want to do?");
        Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, d for division.");
        
        answer = Console.ReadLine();

        switch (answer)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                result = num1 / num2;
                break;
        }
        
        Console.WriteLine($"The result is: {result}");
        Console.WriteLine("Thank you for using the calculator!");
        
        Console.ReadKey();
    }
}

