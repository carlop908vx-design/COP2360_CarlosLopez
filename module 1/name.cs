using System;

class Program
{
    static void Main()
    {
  
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();
        int age = Convert.ToInt32(ageInput);

        int nextYearAge = age + 1;

        Console.WriteLine();
        Console.WriteLine("Nice to meet you, " + name + "!");
        Console.WriteLine("Next year, you will be " + nextYearAge + " years old.");
    }
}