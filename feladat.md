## 1-2. feladat, szám és szó lista létrehozása:

List<int> numberList = new List<int>() { 8, 37, 11, 98, 95, 43, 11, 98, 8, 8, 37 };
List<string> stringList = new List<string>() { "fa", "kép", "daru", "fa", "alma", "doboz", "kép", "doboz", "fa" };
  
## 3-4 feladat: Írd ki a képernyőre a 20-nál nagyobb számokat, minden számról írasd ki, hányszor fordul elő a listában:
  
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
  ## 6. feladat átlagnál kisebb számok kiíratása:

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
                        
  ## 7. feladat Keresd meg a szót amiben a legtöbb s betű található

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
                        
  ## 9. feladat Guessing game

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


