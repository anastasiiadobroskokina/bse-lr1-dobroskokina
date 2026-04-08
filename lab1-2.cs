using System;

/// <summary>
/// Клас Calculator реалізує базову логіку арифметичних операцій.
/// </summary>
class Calculator
{
    // Приватні поля для зберігання операндів та результату
    private double operand1;
    private double operand2;
    private double resultValue;

    /// <summary>
    /// Властивість для доступу до першого числа.
    /// </summary>
    public double Op1
    {
        get { return operand1; }
        set { operand1 = value; }
    }

    /// <summary>
    /// Властивість для доступу до другого числа.
    /// </summary>
    public double Op2
    {
        get { return operand2; }
        set { operand2 = value; }
    }

    /// <summary>
    /// Властивість тільки для читання, що повертає результат останньої операції.
    /// </summary>
    public double Result
    {
        get { return resultValue; }
    }

    // Методи для виконання арифметичних дій
    public void Add() => resultValue = operand1 + operand2;
    public void Subtract() => resultValue = operand1 - operand2;
    public void Multiply() => resultValue = operand1 * operand2;

    /// <summary>
    /// Виконує ділення. Містить перевірку на ділення на нуль.
    /// </summary>
    public void Divide()
    {
        if (operand2 == 0)
        {
            Console.WriteLine("Помилка: не можна ділити на нуль!");
            return;
        }
        resultValue = operand1 / operand2;
    }
}

class Program
{
    /// <summary>
    /// Головна точка входу в програму.
    /// Реалізує інтерфейс взаємодії з користувачем через консоль.
    /// </summary>
    static void Main()
    {
        Calculator calc = new Calculator();

        // Введення даних користувачем
        Console.Write("Введіть перше число: ");
        calc.Op1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        calc.Op2 = double.Parse(Console.ReadLine());

        // Вибір операції
        Console.Write("Оберіть операцію (+ - * /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Логіка виклику відповідних методів класу Calculator
        if (op == '+') calc.Add();
        else if (op == '-') calc.Subtract();
        else if (op == '*') calc.Multiply();
        else if (op == '/') calc.Divide();
        else {
            Console.WriteLine("Помилка: невірна операція.");
            return;
        }

        // Виведення фінального результату
        Console.WriteLine("Результат обчислення: " + calc.Result);
    }
}