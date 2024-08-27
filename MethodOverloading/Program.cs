using System.Net.Http.Headers;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isTrue)
        {
            var result = a + b;
            if (isTrue)
            {
                return $"{result} dollars";
            }
            else
            {
                return $"{result}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 1));                  
            Console.WriteLine(Add(5, 1, true));            
            Console.WriteLine(Add(1, 16, true));            
            Console.WriteLine(Add(1, 16, false));

        }
    }
}
