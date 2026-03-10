namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 100;
                int c;

                if ( b > 10 )
                {
                    throw new AbandonedMutexException("值大於 10");
                }

                c = a / b;

                string[] name = new string[5];
                string id = name[4];
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
            catch (AbandonedMutexException ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("END");
            }
        }
    }
}
