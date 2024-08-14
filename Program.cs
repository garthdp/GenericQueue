namespace GenericQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> numbers = new Queue<string>();

            numbers.Enqueue("One");
            numbers.Enqueue("Two");
            numbers.Enqueue("Three");
            numbers.Enqueue("Four");
            numbers.Enqueue("Five");

            foreach (String number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Dequeing {0}", numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            Console.WriteLine("Dequeing {0}", numbers.Dequeue());
            Console.WriteLine();

            String[] test = { "one", "two", "three", "four" };
            Queue<string> newQue = new Queue<string>(test);
            Console.WriteLine("New que from an array");
            foreach (String number in newQue)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("was four found: {0}", newQue.Contains("four"));
            Console.WriteLine("Clear the queue");
            newQue.Clear();
            Console.WriteLine("New Que: {0}", newQue.Count());
        }
    }
}
