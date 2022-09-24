namespace AdvancedFeatures.Concurrency;

internal class Program
{
    // Create a new Mutex. The creating thread does not own the mutex.
    private static readonly Mutex mutex = new();
    private const int numIterations = 1;
    private const int numThreads = 3;

    private static void Main ()
    {
        // Create the threads that will use the protected resource.
        for (var i = 0; i < numThreads; i++)
        {
            var newThread = new Thread(new ThreadStart(ThreadProc))
            {
                Name = string.Format("Thread{0}", i + 1)
            };

            newThread.Start();
        }

        // The main thread exits, but the application continues to
        // run until all foreground threads have exited.
    }

    private static void ThreadProc ()
    {
        for (var i = 0; i < numIterations; i++)
        {
            // Wait until it is safe to enter.
            Console.WriteLine("{0} is requesting the mutex", Thread.CurrentThread.Name);
            _ = mutex.WaitOne();

            Console.WriteLine("{0} has entered the protected area", Thread.CurrentThread.Name);

            // Place code to access non-reentrant resources here.

            // Simulate some work.
            Thread.Sleep(500);

            Console.WriteLine("{0} is leaving the protected area", Thread.CurrentThread.Name);

            // Release the Mutex.
            mutex.ReleaseMutex();
            Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);

        }
    }
}