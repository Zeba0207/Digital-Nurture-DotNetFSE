using System;
using System.Threading.Tasks;

namespace Exercise23_AsyncFileUpload
{
    internal class Program
    {
        // Simulate File Upload
        static async Task<string> UploadFileAsync(string fileName)
        {
            Console.WriteLine($"Uploading '{fileName}'...");

            // Simulate 3-second delay
            await Task.Delay(3000);

            // Simulate validation
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new Exception("Invalid file name.");
            }

            return $"{fileName} uploaded successfully.";
        }

        static async Task Main(string[] args)
        {
            try
            {
                string result = await UploadFileAsync("Resume.pdf");

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Upload Failed!");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nProgram Finished.");
        }
    }
}