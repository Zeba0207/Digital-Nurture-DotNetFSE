using System;
using System.Diagnostics;

namespace Exercise28_TraceLogging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add a listener to write logs to a file
            Trace.Listeners.Add(new TextWriterTraceListener("ApplicationLog.txt"));

            // Enable auto flush
            Trace.AutoFlush = true;

            Trace.WriteLine("==================================");
            Trace.WriteLine("Application Started");
            Trace.WriteLine($"Date & Time : {DateTime.Now}");

            Console.WriteLine("Performing some operations...");

            int num1 = 20;
            int num2 = 10;
            int result = num1 + num2;

            Trace.WriteLine($"Addition Result : {result}");

            Console.WriteLine($"Result = {result}");

            Trace.WriteLine("Operation Completed Successfully");
            Trace.WriteLine("Application Ended");
            Trace.WriteLine("==================================");

            // Flush and close listeners
            Trace.Flush();
            Trace.Close();

            Console.WriteLine();
            Console.WriteLine("Logs have been written to ApplicationLog.txt");
        }
    }
}