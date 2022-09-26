using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Unit_13._6._1
{
    class Program
    {
      
        static void Main()
        {
            var Text1 = new List<string>();
            var Text2 = new LinkedList<string>();
            string filePath = @"/Text1.txt";
            var watchTwo = Stopwatch.StartNew();
            Text1.Add(filePath);
            Console.WriteLine($"Вставка в List<T>: {watchTwo.Elapsed.TotalMilliseconds}  мс");
            watchTwo.Restart();
            Text2.AddFirst(filePath);
            Console.WriteLine($"Вставка в LinkedList<T>: {watchTwo.Elapsed.TotalMilliseconds}  мс");
            Console.ReadKey();




        }
    }
}
