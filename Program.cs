namespace Assignment_5_2_2
{
    internal class Program
    {
        static void Main(string[] args)

        // Write a program in C# Sharp to print the first n natural number using recursion. 

        {
            Console.WriteLine("Enter the number of natural numbers to print:");
            int numbersToPrint = int.Parse(Console.ReadLine());

            Console.WriteLine("The first {0} natural numbers are:", numbersToPrint);
            PrintNaturalNumbers(numbersToPrint);
        }

        static void PrintNaturalNumbers(int n)
        {
            // Base case: if n is 0, stop recursion
            if (n == 0)
            {
                return;
            }

            // Recursive case: print numbers up to n - 1 first
            PrintNaturalNumbers(n - 1);

            // Print the current number after the recursive call
            Console.WriteLine(n);
        }
    }
}