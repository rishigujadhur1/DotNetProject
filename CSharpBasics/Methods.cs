namespace app
{
    public class Methods
    {
        public void Sum(int a, int b)
        {
            string value = 'a'.ToString();
            Console.WriteLine(a + b);
        }

        // Method overloading
        public void Sum(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        // Parameterless method
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        public void DefaultParamMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        public int MethodWithReturnValue(int x)
        {
            return 5 + x;
        }

    }
}