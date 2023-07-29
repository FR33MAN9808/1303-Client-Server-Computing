using Q23;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create a ConcurrentQueue of integers with a maximum length of 5
        ConcurrentQueue<int> queue = new ConcurrentQueue<int>(5);

        // Enqueue some items
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);

        // Get the current length of the queue
        int length = queue.GetCurrentLength();
        Console.WriteLine("Current length of the queue: " + length);

        // Peek at the next item without dequeuing it
        int nextItem = queue.Peek();
        Console.WriteLine("Next item in line: " + nextItem);

        // Dequeue some items
        int item1 = queue.Dequeue();
        int item2 = queue.Dequeue();

        // Get the current length again
        length = queue.GetCurrentLength();
        Console.WriteLine("Current length of the queue after dequeuing: " + length);

    }
}