using System;

namespace Exercise1
{

    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                var stack = new Stack();
                stack.Push(1);

                stack.Clear();

                stack.Push(2);
                stack.Push(3);

                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
			catch (Exception)
			{

                Console.WriteLine("ガッ");
            }
        }
    }
}
