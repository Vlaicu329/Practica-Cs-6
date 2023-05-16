using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al programa de operaciones!");
        Console.WriteLine("Ingrese dos números enteros para sumar, restar, multiplicar y dividir.");
        Console.Write("Primer número: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Suma: {Addition(x , y)}");
        Console.WriteLine($"Resta: {Subtraction(x , y)}");
        Console.WriteLine($"Multiplicación: {Multiply(x , y)}");
        Console.WriteLine($"División: {Division(x , y)}");
    }

    static int Addition(int a, int b)
    {
        int resultado = a + b;
        Console.WriteLine($"{a} + {b} = {resultado}");
        return resultado;
    }

    static int Subtraction(int a, int b)
    {
        int resultado = a - b;
        Console.WriteLine($"{a} - {b} = {resultado}");
        return resultado;
    }

    static int Multiply(int a, int b)
    {
        int resultado = a * b;
        Console.WriteLine($"{a} * {b} = {resultado}");
        return resultado;
    }

    static int Division(int a, int b)
    {
        int resultado = a / b;
        Console.WriteLine($"{a} / {b} = {resultado}");
        return resultado;
    }
}