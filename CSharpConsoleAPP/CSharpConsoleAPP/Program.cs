using System;


// Создано по видеоуроку https://www.youtube.com/watch?v=0mm3djZ5KpQ&list=PL6tu16kXT9Pp3NFZgLbPZXEykeGQwxGSx&index=2&ab_channel=ExecuteAutomation

namespace CSharpConsoleAPP
{
    class Program
    {

        static void Main(string[] args)
        {
            TestClass1 class1 = new TestClass1();

            class1.SetValue(20);
            class1.GetValue();

            TestClass1 class2 = new TestClass1();

            class2.SetValue(20);
            class2.GetValue();

            Console.WriteLine("Hello World!");
            Console.Read();

        }
    }
}
