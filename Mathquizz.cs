// https://github.com/Teaching-HTL-Leonding/math-quizzes-Davos135






System.Console.WriteLine("First number:");
double firstNumber = double.Parse(Console.ReadLine()!);

System.Console.WriteLine("Second number:");
double secondNumber = double.Parse(Console.ReadLine()!);

System.Console.WriteLine("Summary:");
double result = double.Parse(Console.ReadLine()!);

if (firstNumber + secondNumber == result)
{
    System.Console.WriteLine("the operater is [+].");
}
else if (firstNumber - secondNumber == result)
{
    System.Console.WriteLine("The operater is [-].");

}
else if (firstNumber * secondNumber == result)
{
    System.Console.WriteLine("the operater is [*].");

}
else if (firstNumber / secondNumber == result)
{
    System.Console.WriteLine("the operater is the [/].");
}
else if (Math.Pow(firstNumber, secondNumber) == result)
{
    System.Console.WriteLine("the operater is  the Exponentiation");

}
else if (firstNumber % secondNumber == result)
{
    System.Console.WriteLine(" the operater is [%].");
}
