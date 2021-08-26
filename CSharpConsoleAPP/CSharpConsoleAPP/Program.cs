using System;


// Создано по видеоурокам https://www.youtube.com/watch?v=0mm3djZ5KpQ&list=PL6tu16kXT9Pp3NFZgLbPZXEykeGQwxGSx&index=2&ab_channel=ExecuteAutomation

namespace CSharpConsoleAPP
{
    class Program
    {

        static void Main(string[] args)
        {
            string testCaseState = "Iconclusive";

            if (testCaseState == "PASSED")
            {
                Console.WriteLine("TestCase PASSED");
            }
            else if (testCaseState == "FAILED")
            {
                Console.WriteLine("The CASE FAILED");
            }
            else if (testCaseState == "Iconclusive")
            {
                Console.WriteLine("The CASE Iconclusive");
            }

            Console.Read();
        }

       
    }
}
