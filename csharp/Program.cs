using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = InitialPosAdapter.InitialPos(new int[3, 3] { {1, 2, 3}, {0, 1, 2}, {0, 1, 1} });
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
