namespace CSharpPractice
{
    class IfAndIfElse
    {
        public static void Main(string[] args)
        {
            // if and else if statement

            int a = 2;
            int b = 3;
            int c = 4;

            if(a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if(b > c)
            {
                Console.WriteLine("b is greater than c");
            }
            else
            {
                Console.WriteLine("c is greater than both a and b");
            }
        }
    }
}
