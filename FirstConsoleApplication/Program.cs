int num1;
int num2;
int answer = 0;
char operationChar;

Console.WriteLine("Hello! Please enter the first number.");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello! Please enter the second number.");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello! Please enter the operation you'd like to do (+, -, or *).");
operationChar = Convert.ToChar(Console.ReadLine());

if (operationChar.Equals('+'))
    answer = num1 + num2;
if (operationChar.Equals('-'))
    answer = num1 - num2;
if (operationChar.Equals('*'))
    answer = num1 * num2;

Console.WriteLine("The answer is {0}", answer);