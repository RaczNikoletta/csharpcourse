using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;
using System.IO;

namespace GenerateRandom
{
    class Program
    {
        private static Stopwatch jsonTimer = new Stopwatch();
        static void Main(string[] args)
        {
            var payments = new List<double>();
            jsonTimer.Start();
            DateTime timeStart = DateTime.Now;
            Random rnd = new Random();
            for (int i = 0; i < 100000; i++)
            {
                int num = rnd.Next(200000, 5500000);
                payments.Add(num);
                    
            }

            string json = JsonSerializer.Serialize(payments);
            try {
                System.IO.File.WriteAllText(@"C:\Users\raczn\source\repos\GenerateRandom\GenerateRandom\jsonPayments.json", json);

            }
            catch (UnauthorizedAccessException)
            {
                Console.Write("UnAuthorizedAccessException: Unable to access file. ");
            }
            long duration = jsonTimer.ElapsedMilliseconds;
            DateTime timeStop = DateTime.Now;
            TimeSpan diff = (timeStop - timeStart);
            var secs = diff.TotalMilliseconds;
            Console.WriteLine("Elapsed milliseconds: {0} to write json",secs);


            

            /*timeStart = DateTime.Now;
            for (int i = 0; i < payments.Count; i++)
            {
                payments[i] = payments[i] * 1.1;
            }

            json = JsonSerializer.Serialize(payments);

            try
            {
                System.IO.File.WriteAllText(@"C:\Users\raczn\source\repos\GenerateRandom\GenerateRandom\jsonPayments.json", json);

            }
            catch (UnauthorizedAccessException)
            {
                Console.Write("UnAuthorizedAccessException: Unable to access file. ");
            }

            timeStop = DateTime.Now;
            diff = (timeStop - timeStart);
            secs = diff.TotalMilliseconds;

            Console.WriteLine("Elapsed milliseconds: {0} to update json", secs);*/

        }
    }
}
