using System;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());
            //int fourthNumber = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //if (firstNumber % 2 == 1)
            //{
            //    sum += firstNumber;
            //}

            //if (secondNumber % 2 == 1)
            //{
            //    sum += secondNumber;
            //}

            //if (thirdNumber % 2 == 1)
            //{
            //    sum += thirdNumber;
            //}

            //if (fourthNumber % 2 == 1)
            //{
            //    sum += fourthNumber;
            //}

            //Console.WriteLine(sum);

            //int numbersSize = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[numbersSize];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Ededi daxil edin: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //var maxNumber = FindLargestNumber(numbers);

            //Console.WriteLine();


            string[] names = { "Eli", "Veli", "Oruc", "Vahid" };
            string name = "sddsfadsf";
            bool varmi = false;

            foreach (string ad in names) {
                if (ad == name)
                {
                    varmi = true;
                    break;
                }
            }


            if (varmi)
            {
                Console.WriteLine("var");
            }else
            {
                Console.WriteLine("Yoxdur");
            }






        }

        public static int FindLargestNumber(int[] numbers)
        {
            Console.WriteLine("Massivin olcusun daxil edin: ");

            int largestNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (largestNumber < numbers[i])
                {
                    largestNumber = numbers[i];
                }
            }

            return largestNumber;
        }
    }
}
