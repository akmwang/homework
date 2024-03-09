using System;
class Calcu
{
    public static void Calculate(int a, int b, char c)
    {
        switch(c)
        {
            case '+':
                Console.WriteLine(a + b);
                break;
            case '-':
                Console.WriteLine(a - b);
                break;
            case '*':
                Console.WriteLine(a * b);
                break;
            case '/':
                Console.WriteLine(a / b);
                break;
            default: 
                Console.WriteLine("Wrong");
                break;
        }
    }
    static void Main()
    {
        Calcu.Calculate(1, 2, '+');
        Calcu.Calculate(1, 2, '-');
        Calcu.Calculate(1, 2, '*');
        Calcu.Calculate(1, 2, '/');
    }
}