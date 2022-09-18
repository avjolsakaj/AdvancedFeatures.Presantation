namespace AdvancedFeatures.Collections
{
    internal class Program
    {
        private static void Main (string[] args)
        {
            //Console.WriteLine("Dictionary: ");

            //var dictionary = new Dictionary<string, int>();

            //dictionary.Add("Cat", 2);
            //dictionary.Add("Dog", 1);
            //dictionary.Add("Bird", 0);
            //dictionary.Add("bird", 0);

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine("{0}, {1}", item.Key, item.Value);
            //}

            Console.WriteLine("List: ");

            var list = new List<int>();
            list.Add(2);
            list.Add(5);
            list.Add(7);
            list.Add(3);

            //var list = new List<int>
            //{
            //    2,
            //    5,
            //    7,
            //    3
            //};

            list.Add(3);

            var list2 = list.Where(x => x > 3).ToList();

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("Queue: ");

            //var queue = new Queue<string>();
            //queue.Enqueue("One");
            //queue.Enqueue("Two");
            //queue.Enqueue("Three");
            //queue.Enqueue("Four");

            ////_ = queue.Dequeue();
            ////_ = queue.Dequeue();

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //    //queue.Dequeue();
            //}

            //Console.WriteLine("stack: ");

            //var stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(10);
            //stack.Push(100);
            //stack.Push(1000);

            ////_ = stack.Pop();

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //    // stack.Pop();
            //}

            var stackWithReadLine = new Stack<int>();
            var queueWithReadLine = new Queue<int>();

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Write stack item:");

                var s = Console.ReadLine();

                var itemNumber = int.Parse(s!);

                stackWithReadLine.Push(itemNumber);
                queueWithReadLine.Enqueue(itemNumber);
            }

            Console.WriteLine("Stack print:");
            foreach (var item in stackWithReadLine)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Queue print:");
            foreach (var item in queueWithReadLine)
            {
                Console.WriteLine(item);
            }

            var listFromStack = stackWithReadLine.ToList();

            Console.WriteLine("List print:");
            foreach (var item in listFromStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ordered List print:");
            var orderedList = listFromStack.OrderBy(x => x);
            foreach (var item in orderedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}