using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsoleAPP
{
    class TestClass1
    {

        public void Add()
        {
            Console.WriteLine("This is empty Add method: ");
        }
        public void Add(int num1, int  num2)
        {
            int result = num1 + num2;

            Console.WriteLine("This is Add method with two params: "+ result);
        }
    }
}
