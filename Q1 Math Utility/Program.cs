using System;

class MathUtility
{
    static long CalcFact(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    static bool CheckPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void GenFactSeries(int count)
    {
        for (int i = 0; i < count; i++)
        {
            long factorial = CalcFact(i);
            Console.WriteLine($"Factorial of {i} is {factorial}");
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mathematics Utility Menu:");
            Console.WriteLine("1. Calculate Factorial");
            Console.WriteLine("2. Check Prime Number");
            Console.WriteLine("3. Generate Factorial Series");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a number to calculate its factorial: ");
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            long factorial = CalcFact(num);
                            Console.WriteLine($"Factorial of {num} is {factorial}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter a number to check if it's prime: ");
                        if (int.TryParse(Console.ReadLine(), out int primeNum))
                        {
                            bool isPrime = CheckPrime(primeNum);
                            Console.WriteLine($"{primeNum} is {(isPrime ? "prime" : "not prime")}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a whole number.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter the count of factorial series to generate: ");
                        if (int.TryParse(Console.ReadLine(), out int n3))
                        {
                            GenerateFactorialSeries(n3);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }

            Console.WriteLine(); 
        }
    }
    static long CalculateFactorial(int n)
    {
        if (n < 0)
            return -1; 
        if (n == 0)
            return 1;
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
    static void GenerateFactorialSeries(int terms)
    {
        for (int i = 0; i < terms; i++)
        {
            long factorial = CalculateFactorial(i);
            Console.WriteLine($"Factorial of {i} is {factorial}");
        }
    }
}