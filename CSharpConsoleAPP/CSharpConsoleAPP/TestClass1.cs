using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAPP
{
    class TestClass1
    {

        private int i = 0;

        public void SetValue(int value)
        {
            i = value;
        }

        public void GetValue()
        {
            Console.WriteLine("The value of i is: " + i);
        }

        //Members https://www.youtube.com/watch?v=NNYJjn9b2-0&list=PL6tu16kXT9Pp3NFZgLbPZXEykeGQwxGSx&index=4&ab_channel=ExecuteAutomation
        public void TestCase1(string result)
        {
            Console.WriteLine("Executing TestCase1 "+ result);
        }
        public void TestCase2(string result)
        {
            Console.WriteLine("Executing TestCase2 " + result);
        }
    }
}
