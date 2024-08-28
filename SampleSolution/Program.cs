// See https://aka.ms/new-console-template for more information
using SampleSolution;

Console.WriteLine("Hello, World!");

Calculator calculator = new Calculator();

// Step 7: Call Add and display the result
int result = calculator.Add(5, 7);
Console.WriteLine("The result of adding 5 and 7 is: " + result);