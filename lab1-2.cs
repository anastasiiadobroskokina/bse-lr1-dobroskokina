using System;
class Calculator
{
    private double operand1;
    private double operand2;
    private double resultValue;

    public double Op1
    {
        get { return operand1; }
        set { operand1 = value; }
    }

    public double Op2
    {
        get { return operand2; }
        set { operand2 = value; }
    }

    public double Result
    {
        get { return resultValue; }
    }

    public void Add() => resultValue = operand1 + operand2;
    public void Subtract() => resultValue = operand1 - operand2;
    public void Multiply() => resultValue = operand1 * operand2;

    public void Divide()
    {
        if (operand2 == 0)
        {
            Console.WriteLine("не можна ділити на нуль");
            return;
        }
        resultValue = operand1 / operand2;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.Write("введіть перше число: ");
        calc.Op1 = double.Parse(Console.ReadLine());

        Console.Write("введіть друге число: ");
        calc.Op2 = double.Parse(Console.ReadLine());

        Console.Write("операція (+ - * /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (op == '+') calc.Add();
        else if (op == '-') calc.Subtract();
        else if (op == '*') calc.Multiply();
        else if (op == '/') calc.Divide();
        else {
            Console.WriteLine("невірна операція");
            return;
        }
        Console.WriteLine("результат: " + calc.Result);
    }
}