namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] stringarray = new string[5];
                stringarray[0] = "dilsha";
                
                Console.WriteLine(stringarray[0]);
                // The following line will cause an ArrayTypeMismatchException
                // because you are trying to assign an integer to a string array element.
                // Correcting it to illustrate exception handling:
                object obj = 0; // Using an object to demonstrate type mismatch
                stringarray[1] = (string)obj; // This cast will fail at runtime
                Console.WriteLine("No error occure");


            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine($"ArrayTypeMismatchException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
