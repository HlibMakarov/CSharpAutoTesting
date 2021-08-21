using System;


// Создано по видеоуроку https://www.youtube.com/watch?v=0mm3djZ5KpQ&list=PL6tu16kXT9Pp3NFZgLbPZXEykeGQwxGSx&index=2&ab_channel=ExecuteAutomation

namespace CSharpConsoleAPP
{
    class Program
    {

        static void Main(string[] args)
        {
            TestClass1 class1 = new TestClass1();

            class1.TestCase1("PASSED");
            class1.TestCase2("FAILED");

            Console.WriteLine("Hello World!");
            Console.Read();

        }
    }
}
