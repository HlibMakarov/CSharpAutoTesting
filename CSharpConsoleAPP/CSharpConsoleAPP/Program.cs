using System;


// Создано по видеоурокам https://www.youtube.com/watch?v=0mm3djZ5KpQ&list=PL6tu16kXT9Pp3NFZgLbPZXEykeGQwxGSx&index=2&ab_channel=ExecuteAutomation

namespace CSharpConsoleAPP
{
    class Program
    {

        static void Main(string[] args)
        {
            TestClass1 testClass = new TestClass1();
            testClass.Add(12, 12);
           

            Console.Read();

        }

        private static void NewMethod()
        {
            //Implicit conversion
            Int16 salary = 32767;
            int salaryIncrement = salary;
            salaryIncrement = 3276745;
            Console.WriteLine(salaryIncrement);

            var incomeTax = 23234.234d;

            Console.WriteLine(incomeTax.GetType().Name);
            Console.WriteLine((int)incomeTax);

            var loginPage2 = new LoginPage();
            loginPage2.ClickButton();
            //((UserListPage)loginPage2).ClickButton();
        }

        public class LoginPage
        {
            public string UserName { get; set; }

            public void ClickButton()
            {

            }
        }
        public class UserListPage
        {
            public string ListOfUsers { get; set; }
        }
    }
}
