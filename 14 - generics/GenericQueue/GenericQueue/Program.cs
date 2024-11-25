namespace GenericQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var queue = new GenericQueue<int>();

            
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            Console.WriteLine("Peek: " + queue.Peek()); 
            Console.WriteLine("Dequeue: " + queue.Dequeue()); 
            Console.WriteLine("Dequeue: " + queue.Dequeue()); 

            queue.Enqueue(50);
            queue.Enqueue(60);

            Console.WriteLine("Peek: " + queue.Peek()); 
            Console.WriteLine("Count: " + queue.Count); 

        }
    }
}
