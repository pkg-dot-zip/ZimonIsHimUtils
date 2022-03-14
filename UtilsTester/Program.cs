﻿using System;
using ZimonIsHimUtils.ExtensionMethods;

namespace UtilsTester
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //
            // Console.WriteLine("Now testing Int32.");
            // 10.DoFor(PrintTest);
            //
            // Console.WriteLine("Now testing Floats.");
            // 5F.DoFor(PrintTest);
            //
            // "Test".DoFor(PrintTest);
            // 'a'.DoFor(PrintTest);
            // 0.23.DoFor(PrintTest);
            // (100 + 50 / 2F * 50.29).DoFor(PrintTest);
            // Math.PI.DoFor(PrintTest);
            // false.DoFor(PrintTest);
            // DateTime.MaxValue.DoFor(PrintTest);

            // Action a = PrintTest;
            // a.DoFor(5);

            Action<string> thing = PrintTest;
            thing.DoFor("TestMaarEens", 5);
        }

        private static void PrintTest()
        {
            Console.WriteLine("Test");
        }

        private static void PrintTest(string s)
        {
            Console.WriteLine(s);
        }
    }
}
