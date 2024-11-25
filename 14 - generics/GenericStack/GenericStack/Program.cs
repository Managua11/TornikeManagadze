namespace GenericStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new GenericStack<int>();
            var stack2 = new GenericStack<string>();
           
            stack.Push(17);
            stack.Push(23);
            stack2.Push("kd");

            Console.WriteLine("Peek: " + stack.Peek()); 
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Peek: " + stack.Peek());
            Console.WriteLine("string stack peek: " + stack2.Pop());

            stack.Push(-3);
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Count: " + stack.Count);
        }
    }
}
