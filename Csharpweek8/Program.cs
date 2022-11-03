using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GenerateRandom
{
    class Program
    {
        const string filePath = @"C:\Users\raczn\source\repos\GenerateRandom\GenerateRandom\jsonPayments.json";
        public static void Serialize(object obj)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public class payment
        {
            public double salary;

            public payment(double pay) { salary = pay; }

            public double getSalary()
            {
                return salary;
            }
        }

        public static object Deserialize(string path)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamReader(path))
            using (var reader = new JsonTextReader(sw))
            {
                return serializer.Deserialize(reader);
            }
        }
        static void Main(string[] args)
        {
            var payments = new List<payment>();
            //DateTime timeStart = DateTime.Now;
            Random rnd = new Random();
            for (int i = 0; i < 100000; i++)
            {
                int num = rnd.Next(200000, 5500000);
                payment pay = new payment(Decimal.ToDouble(num));
                payments.Add(pay);
                    
            }
            DateTime timeStart = DateTime.Now;
            Serialize(payments);

            DateTime timeStop = DateTime.Now;
            TimeSpan diff = (timeStop - timeStart);
            var secs = diff.TotalMilliseconds;
            Console.WriteLine("Elapsed milliseconds: {0} to write json",secs);


            timeStart = DateTime.Now;
            Deserialize(filePath);
         
            timeStop = DateTime.Now;
            diff = (timeStop - timeStart);
            secs = diff.TotalMilliseconds;
            Console.WriteLine("Elapsed milliseconds: {0} to read json", secs);

            timeStart = DateTime.Now;
            for (int i = 0; i < payments.Count; i++)
            {
                payments[i].salary *= 1.1;
            }
            Serialize(payments);
            timeStop = DateTime.Now;
            diff = (timeStop - timeStart);
            secs = diff.TotalMilliseconds;
            Console.WriteLine("Elapsed milliseconds: {0} to update json", secs);

            
            for (int i = 0; i < 100000; i++)
            {
                int num = rnd.Next(200000, 5500000);
                payment pay = new payment(Decimal.ToDouble(num));
                payments.Add(pay);
                

            }
            //File.AppendAllLines
            //File.WriteAllText(@"C:\Users\raczn\source\repos\GenerateRandom\GenerateRandom\Payments.txt", payments);

          

           

        }
    }
}
