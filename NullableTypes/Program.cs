using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            // We need to use GetValueOrDefault in this case
            DateTime date2 = date.GetValueOrDefault();

            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            
            // This one gonna have an exception because the value is null
            Console.WriteLine(date.Value);
        }
    }
}
