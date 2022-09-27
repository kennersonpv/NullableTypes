using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            
            // This one gonna have an exception because the value is null
            Console.WriteLine(date.Value);
        }
    }
}
