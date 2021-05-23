using System;

namespace Practic_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1;
            int[] numbers = {4, 5, 1, 6, 2, 7, 3};
            int minNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (minNumber > (int)Math.Abs(Convert.ToDouble(numbers[i])))
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine("Задание 1: " + minNumber + "\n");

            //Задание 2
            int[] numbers2 = { 4, 4, 1, 4, 2, 4, 4 , 5, 5, 6};
            Console.WriteLine("Задание 2: ");
            for (int i = 0; i < numbers2.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers2.Length; j++)
                {
                   

                    if (numbers2[i] == numbers2[j])
                    {
                        count++;
                    }
                }

                if (count > 1)
                {
                    count = 0;
                }
                else
                {
                    Console.Write(numbers2[i] + " ");
                    count = 0;
                }
            }

            //Задание 3
            Random random = new Random();
            int[] numbers3 = new int[10];
            
            Console.WriteLine("\n\nЗадание 3: \nВсе числа: ");
            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers3[i] = random.Next(-10, 10);
                Console.Write(numbers3[i] + " ");
            }

            Console.WriteLine("\n\nПоложительные числа: ");
            for (int i = 0; i < numbers3.Length; i++)
            {
                if (numbers3[i] > 0)
                {
                    Console.Write(numbers3[i] + " ");
                }
            }
            
            
            

            
        }
    }
}
