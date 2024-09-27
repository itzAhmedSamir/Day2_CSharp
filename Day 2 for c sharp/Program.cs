namespace Day_2_for_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q_1 Print the first 10 multiples of 5
            Console.WriteLine("The first 10 multiples of 5 are: ");
            int num = 1, result;
            do
            {
                result = num * 5;
                Console.WriteLine($"{num} x 5 = {result}");
                num++;

            } while (num <= 10);
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_2 Calculate the factorial of a given number
            Console.Write("Please enter a number to calculate its factorial: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {number} is: {factorial}");
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_3 Calculate the sum of all even numbers between 1 & 100
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of all even numbers between 1 & 100 are: " + sum);
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_4 Print the multiplication table for all numbers from 1 to 12
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("End of multiplication table for number {0}", i);
            }
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_5 Print all prime numbers between 1 and 500
            Console.WriteLine("Prime numbers between 1 and 500 are: ");
            for (int outer = 2; outer <= 500; outer++)
            {
                bool isPrime = true;
                for (int inner = 2; inner <= Math.Sqrt(outer); inner++)
                {
                    if (outer % inner == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.Write(outer + " ");
                }
            }
            Console.WriteLine();
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_6 Print a pattern
            for (char i = 'a'; i <= 'z'; i++)
            {
                for(char j = 'a';j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_7 
            int minimum = 1000000000;
            int maximum = -1000000000;
            int[] arr1 = {2,-5,9,20,53,-13,6,10,-19,17};
            for (int i = arr1[0]; i < arr1.Length; i++)
            {
                if (arr1[i] < minimum)
                {
                   minimum = arr1[i];
                }
                if (arr1[i] > maximum)
                {
                    maximum = arr1[i];
                }
            }
            Console.WriteLine("Maximum element in the array is: "+ maximum);
            Console.WriteLine("Minimum element in the array is: " + minimum);

            #endregion
            Console.WriteLine("----------------------------");
            #region Q_8 
            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Original array:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Reversed array:");
            for (int i = arr2.Length - 1; i >= 0; i--)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_9
            int[] numbers = new int[5];
            Console.WriteLine("Please enter 5 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array elements in reversed order:");
            int index = numbers.Length - 1;
            while (index >= 0)
            {
                Console.Write(numbers[index] + " ");
                index--;
            }
            Console.WriteLine();
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_10
            Console.WriteLine("All numbers from 1 to 100 without numbers that are multiples of 3: ");
            for (int i=1; i<=100; i++)
            {
                if (i % 3 != 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_11
            Console.Write("Enter a number: ");
            int numb = int.Parse(Console.ReadLine());
            bool is_Prime = true;

            if (numb <= 1)
            {
                is_Prime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numb); i++)
                {
                    if (numb % i == 0)
                    {
                        is_Prime = false;
                        break;
                    }
                }
            }

            if (is_Prime)
            {
                Console.WriteLine($"Number {numb} is Prime");
            }
            else
            {
                Console.WriteLine($"Number {numb} is NOT Prime");
            }
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_12
            Console.WriteLine("First 20 prime numbers are: ");
            int count = 0; 
            int num_ = 2;   
            while (count < 20)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(num_); i++)
                {
                    if (num_ % i == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(num_);
                    count++;
                }

                num_++;
            }
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_13

            int[] array = { -2, 14, -5, 1, 5, 0, -22, 10, -8, 16 };

            int evenCount = 0;
            int oddCount = 0;
            int positiveCount = 0;
            int negativeCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                if (array[i] > 0)
                {
                    positiveCount++;
                }
                else if (array[i] < 0)
                {
                    negativeCount++;
                }
            }

            Console.WriteLine("Count of even numbers in the array is: " + evenCount);
            Console.WriteLine("Count of odd numbers  in the array is: " + oddCount);
            Console.WriteLine("Count of positive numbers in the array is: " + positiveCount);
            Console.WriteLine("Count of negative numbers in the array is: " + negativeCount);
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_14
            Console.Write("Please enter a number that fibonacci sequence up to it: ");
            int n = int.Parse(Console.ReadLine());

            int firstNumber = 0;
            int secondNumber = 1;
            int nextNumber;

            Console.WriteLine("Fibonacci Sequence:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(firstNumber + " ");
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            Console.WriteLine();
            #endregion
            Console.WriteLine("----------------------------");
            #region Q_15
            int[] arr = { 1, 2, 3, 2, 1 };

            bool isPalindrome = true;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length-1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("The array is a palindrome.");
            }
            else
            {
                Console.WriteLine("The array is not a palindrome.");
            }
            #endregion
        }
    }
}
