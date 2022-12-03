using System;

namespace _11_LinkedListImplementation
{
    internal class Startup
    {
        private static void Main()
        {
            var list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddLast(1000);
            list.AddLastRange(new[] { 1, 2, 3 });


            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}
