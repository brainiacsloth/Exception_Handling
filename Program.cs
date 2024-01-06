using System;

class Program
{
    static void Main()
    {
        try
        {
            // Code that might cause an exception
            int divisor = 0;
            int result = 10 / divisor;  // This line will cause a DivideByZeroException
            Console.WriteLine(result);  // This line won't be reached due to the exception
        }
        catch (DivideByZeroException ex)
        {
            // Handle the DivideByZeroException
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Cleanup code (optional) that will always be executed
            Console.WriteLine("Finally block executed.");
        }

        try
        {
            // Code that explicitly throws an exception
            int value = -1;
            if (value < 0)
            {
                throw new ArgumentException("Value cannot be negative.");
            }
        }
        catch (ArgumentException ex)
        {
            // Handle the ArgumentException
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
