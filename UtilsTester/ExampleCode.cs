using System;
using System.Collections.Generic;
using ZimonIsHimUtils.ExtensionMethods;

namespace UtilsTester
{
    internal class ExampleCode
    {
        internal static void Example()
        {
            IList<int> list = new List<int> {1, 5, 6};
            list.Each(PrintTestI); // ForEach() method replacement for IEnumerable (instead of List).

            30.DoFor(PrintTest); // Run action 30 times.
            30.DoFor(PrintTestI); // Run action 30 times and pass iteration as parameter.

            bool aBoolean = false;
            aBoolean.Flip(); // Flips the boolean; turns true into false and vice versa.

            RunOperationOnAction(PrintTest);
        }

        private static void RunOperationOnAction(Action action)
        {
            action.DoFor(21); // Run action 21 times.
        }

        private static void PrintTestI(int i) => Console.WriteLine($"Hello {i}");
        private static void PrintTest() => Console.WriteLine("Hello");
    }
}