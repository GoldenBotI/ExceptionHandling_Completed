namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicExceptionHandling();
            MultipleExceptionTypes();
            FinalyBlockUsage();
            CustomExceptionClass();
            ExceptionPropagation();
            UsingThrowAndCatch();
        }

        static void BasicExceptionHandling()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Convert the input to an integer using int.Parse().
            // Use a try-catch block to handle FormatException if the user enters a non-numeric value.
            // Display an error message in case of an exception.
            // Output the input if correct
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(input);
            }
            catch (FormatException)
            { 
                Console.WriteLine("Caution! A non-numeric value was entered."); 
            }
        }

        static void MultipleExceptionTypes()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Include a catch block for OverflowException to handle cases where the number is too large or small for an int.
            // Display appropriate error messages for different exceptions.
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Caution! A non-numeric value was entered.");
            }
            catch (OverflowException) 
            { 
                Console.WriteLine("Caution! An entered number is too large or small for programm to handle."); 
            }
        }

        static void FinalyBlockUsage()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Add a finally block to the program.
            // Use the finally block to display a message whether an exception was caught or not.
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Caution! A non-numeric value was entered.");
            }
            finally 
            {
                Console.WriteLine("An exception was successfuly catched.");
            }
        }

        // Class for custom exception type
        class NegativeNumberException : ApplicationException
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        static void CustomExceptionClass()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Modify your number input program to throw NegativeNumberException if the user enters a negative number.
            // Handle this exception in a separate catch block and display an appropriate message.
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                    throw new NegativeNumberException("Negative number shouldn't be entered.");
            }
            catch (NegativeNumberException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void ExceptionPropagation()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumber that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // In this function, call CheckNumber inside a try block and handle the exception.
            try
            {
                int input = int.Parse(Console.ReadLine());
                CheckNumber(input);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Entered number shouldn't be greater that 100.");
            }
        }

        // NOTE: You can implement the CheckNumber here
        static void CheckNumber(int input)
        {
            if (input > 100)
                throw new IndexOutOfRangeException();
        }

        static void UsingThrowAndCatch()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumberWithLogging that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // Modify the CheckNumberWithLogging function to log the exception message before throwing it.
            // In this function, catch the exception in the main program and display the logged message.
            try
            {
                int input = int.Parse(Console.ReadLine());
                CheckNumberWithLogging(input);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // NOTE: You can implement the CheckNumberWithLogging here
        static void CheckNumberWithLogging(int input)
        {
            if (input > 100)
            {
                Console.WriteLine("Logged message - entered number shouldn't be greater that 100.");
                throw new ArgumentOutOfRangeException("Entered number shouldn't be greater that 100.");
            }
        }
    }
}