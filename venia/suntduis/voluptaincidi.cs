using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Example of running a method asynchronously
        await RunAsyncOperation();
    }

    static async Task RunAsyncOperation()
    {
        // Simulating an asynchronous operation that takes 3 seconds to complete
        Console.WriteLine("Async operation started...");
        await Task.Delay(3000);
        Console.WriteLine("Async operation completed.");
    }
}
