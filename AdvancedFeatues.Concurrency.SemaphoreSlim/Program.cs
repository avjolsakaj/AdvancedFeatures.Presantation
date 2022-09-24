namespace AdvancedFeatues.Concurrency.SemaphoreSlim;

internal class Program
{
    private static System.Threading.SemaphoreSlim _semaphore;
    // A padding interval to make the output more orderly.
    private static int _padding;

    public static void Main ()
    {
        Console.WriteLine("Semaphore Slim");

        // Create the semaphore.
        _semaphore = new System.Threading.SemaphoreSlim(0, 3);
        Console.WriteLine("{0} tasks can enter the semaphore.", _semaphore.CurrentCount);

        var tasks = new Task[5];

        // Create and start five numbered tasks.
        for (var i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                // Each task begins by requesting the semaphore.
                Console.WriteLine("Task {0} begins and waits for the semaphore.", Task.CurrentId);

                int semaphoreCount;
                _semaphore.Wait();
                try
                {
                    _ = Interlocked.Add(ref _padding, 100);

                    Console.WriteLine("Task {0} enters the semaphore.", Task.CurrentId);

                    // The task just sleeps for 1+ seconds.
                    Thread.Sleep(1000 + _padding);
                }
                finally
                {
                    semaphoreCount = _semaphore.Release();
                }
                Console.WriteLine("Task {0} releases the semaphore; previous count: {1}.", Task.CurrentId, semaphoreCount);
            });
        }

        // Wait for half a second, to allow all the tasks to start and block.
        Thread.Sleep(500);

        // Restore the semaphore count to its maximum value.
        Console.Write("Main thread calls Release(3) --> ");

        _ = _semaphore.Release(3);

        Console.WriteLine("{0} tasks can enter the semaphore.", _semaphore.CurrentCount);

        // Main thread waits for the tasks to complete.
        Task.WaitAll(tasks);

        Console.WriteLine("Main thread exits.");
    }
}