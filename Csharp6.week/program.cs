using System;
using System.Collections.Generic;
using System.Linq;

public class Program
    {

        public static void Main()
        {
            List<int> numberList = new List<int>() { 8, 37, 11, 98, 95, 43, 11, 98, 8, 8, 37 };
            List<string> stringList = new List<string>() { "fa", "kép", "daru", "fa", "alma", "doboz", "kép", "doboz", "fa", "teszt" };
            List<int> counter = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] counts;
        Console.WriteLine("Task 3\n");
           foreach (var num in numberList)
            {
                if (num > 20)
                {
                    Console.WriteLine(num);
                      
                }
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else {
                dict.Add(num, 1);
            }

            }
        Console.WriteLine("Task 4\n");
        foreach(var i in dict)
        {
            Console.WriteLine("Number: {0}, occurrence: {1}", i.Key, i.Value);
        
        }

        Console.WriteLine("Task 6\n Below the average: ");
        double avg = numberList.Average();
        Console.WriteLine("Average: {0}\nBelow the average:",avg);
        foreach (var i in numberList)
        {
            if (i < avg)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Task 7\n Number of s: ");
        List<int> stringcounter =new List<int>() { 0, 0, 0, 0,0, 0, 0, 0, 0,0 };
        char charCount = 's';

        for(int i=0;i<stringList.Count;i++)
        {

            foreach (char s in stringList[i])
            {
                if (s == charCount)
                {
                    stringcounter[i]++;
                    //Console.WriteLine(stringcounter[i]);
                }
            }
        }
        int whereIsMax = 0;
        for(int i =0; i<stringcounter.Count; i++)
        {
            if (stringcounter[i] == stringcounter.Max())
            {
                whereIsMax = i;
            }
        }
        //Console.WriteLine(stringcounter.Max());
        Console.WriteLine("Contains most s letter: {0}", stringList[whereIsMax]);


        Console.WriteLine("Task 9");

        Random rnd = new Random();

        int random = rnd.Next(0, 21);
        while (true)
        {
            Console.WriteLine("Enter a number between 0 and 20 (exit with 999)");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 999)
            {
                Console.WriteLine("I am sorry you give up, the number was {0}", random);
                break;
            }
            else if (input < random)
            {
                Console.WriteLine("Number is low, try again");
            }
            else if (input > random)
            {
                Console.WriteLine("Number is high, try again");
            }
            else
            {
                Console.WriteLine("Good job, the number is {0}", random);
                break;
            }

                
        }
    }
        

    }
