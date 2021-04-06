using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            
            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 100);
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Task1(arr);
            //Task2(arr);
            //Task3(arr);
            //Task4(arr);
            //Task5(arr);
            //Task6();
            //Task7();

            
        }

        
        static void Task1(int[,] arr)
        {
            int minElem = arr[0,0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] < minElem)
                    {
                        minElem = arr[i, j];
                    }                        
                }
            }
            Console.WriteLine($"Minimum Element of array is = {minElem}");
        }
        static void Task2(int[,] arr)
        {
            int maxElem = arr[0, 0];
          
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > maxElem)
                    {
                        maxElem = arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Maximum Element of array is = {maxElem}");
        }
        static void Task3(int[,] arr)
        {

            int firstIndex = 0;
            int secondIndex = 0;
            int minElem = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < minElem)
                    {
                        minElem = arr[i, j];
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    secondIndex = j;

                    if (arr[i, j] == minElem)
                    {
                        break;
                    }   
                }
                firstIndex = i;

                if (arr[i, secondIndex] == minElem)
                {
                    break;
                }
            }
            Console.WriteLine($"Index of minimal element is = [{firstIndex},{secondIndex}]");
        }
        static void Task4(int[,] arr)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            int maxElem = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > maxElem)
                    {
                        maxElem = arr[i, j];
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    secondIndex = j;

                    if (arr[i, j] == maxElem)
                    {
                        break;
                    }
                }
                firstIndex = i;

                if (arr[i, secondIndex] == maxElem)
                {
                    break;
                }
            }
            Console.WriteLine($"Index of maximal element is = [{firstIndex},{secondIndex}]");
        }
        static void Task5(int[,] arr)
        {
            int count = 0;
            int colLength = arr.GetLength(0) - 1;
            int rowLength = arr.GetLength(1) - 1;

            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == 0 && i == 0)
                    {
                        if (arr[i, j] > arr[i, j + 1])
                        {
                            ++count;
                        }
                    }
                    else if (j == rowLength && i == colLength)
                    {
                        if (arr[i, j] > arr[i, j - 1])
                        {
                            ++count;
                        }
                    }
                    else if(j == 0 && i != 0)
                    {
                        if (arr[i, j] > arr[i - 1, rowLength] && arr[i, j] > arr[i, j + 1])
                        {
                            ++count;
                        }
                    }
                    else if (j == rowLength && i != colLength)
                    {
                        if (arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i + 1, 0])
                        {
                            ++count;
                        }
                    }
                    else
                    {
                        if (arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1])
                        {
                            ++count;
                        }
                    }

                }
            }
            
            Console.WriteLine($"Numbers of array elements that are larger than all their neighbors is = {count}");
        }
        static void Task6()
        {
            string[][] numbersInWords = new string[3][];

            numbersInWords[0] = new string[20]
            {
                "zero","one","two","three","four","five","six","seven","eight","nine","ten","eleven",
                "twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"
            };
            numbersInWords[1] = new string[8]
            {
                "twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"
            };
            numbersInWords[2] = new string[2]
            {
                " hundred"," hundred and "
            };

            string escape;

            do
            {
                Console.WriteLine("Enter an integer from 0 to 999");

                if (!int.TryParse(Console.ReadLine(), out int number) || number < 0 || number > 999)
                {
                    Console.WriteLine("Incorrect value, try again");
                    return;
                }

                int firstNum = 0;
                int secondNum = 0;
                int thirdNum = 0;

                if (number > 99)
                {
                    thirdNum = number % 10;
                    secondNum = (number / 10) % 10;
                    firstNum = ((number / 10) / 10) % 10;

                    if (secondNum == 0 && thirdNum == 0)
                    {
                        Console.Write(numbersInWords[0][firstNum] + numbersInWords[2][0] + "\n");
                    }
                    else if (firstNum != 0 && secondNum == 0 && thirdNum != 0)
                    {
                        Console.Write(numbersInWords[0][firstNum] + numbersInWords[2][1] + numbersInWords[0][secondNum + thirdNum] + "\n");
                    }
                    else if (secondNum != 0 && firstNum != 0 && thirdNum != 0)
                    {
                        if (number % 100 < 20)
                        {
                            Console.Write(numbersInWords[0][firstNum] + numbersInWords[2][1] + numbersInWords[0][number % 100] + "\n");
                        }
                        else
                        {
                            Console.Write(numbersInWords[0][firstNum] + numbersInWords[2][1] + numbersInWords[1][secondNum - 2] + "-" + numbersInWords[0][thirdNum] + "\n");
                        }

                    }
                    else if (firstNum != 0 && secondNum != 0 && thirdNum == 0)
                    {
                        if (number % 100 < 11)
                        {
                            Console.Write(numbersInWords[0][firstNum] + numbersInWords[2][1] + numbersInWords[0][number % 100] + "\n");
                        }
                        else
                        {
                            Console.Write(numbersInWords[0][firstNum] + numbersInWords[2][1] + numbersInWords[1][secondNum - 2] + "\n");
                        }
                    }
                }
                else if (number > 19 && number < 100)
                {
                    firstNum = number % 10;
                    secondNum = (number / 10) % 10;

                    Console.Write(numbersInWords[1][secondNum - 2]);

                    if (firstNum != 0)
                    {
                        Console.Write("-" + numbersInWords[0][firstNum] + "\n");
                    }
                }
                else
                {
                    firstNum = number;
                    Console.WriteLine(numbersInWords[0][firstNum]);
                }
                
                Console.WriteLine("Press 'y' to escape");
                escape = Console.ReadLine();
            } while (escape != "y");

   
            
        }
        static void Task7()
        {
            Console.WriteLine("Convert words to numbers");
            Console.WriteLine("Enter your numbers in a words");
            string number = Console.ReadLine();

            string[] ones = {
                "one", "two", "three", "four", "five", "six",
                "seven", "eight", "nine"
            };
            string[] teens = {
                "eleven", "twelve", "thirteen", "fourteen", "fifteen",
                "sixteen", "seventeen", "eighteen", "nineteen"
            };
            string[] tens = {
                "ten", "twenty", "thirty", "forty", "fifty", "sixty",
                "seventy", "eighty", "ninety"
            };
            var bigscales = new Dictionary<string, int>() {
                {"hundred", 100}, {"hundreds", 100}
            };

            string[] minusWords = { "minus", "negative" };
            var splitchars = new char[] { ' ', '-', ',' };

            var lowercase = number.ToLower();
            var inputwords = lowercase.Split(splitchars, StringSplitOptions.RemoveEmptyEntries);

            int result = 0;
            int currentResult = 0;
            int bigMultiplierValue = 1;
            bool bigMultiplierIsActive = false;
            bool minusFlag = false;

            foreach (string curword in inputwords)
            {               
                if (bigscales.ContainsKey(curword))
                {
                    bigMultiplierValue *= bigscales[curword];
                    bigMultiplierIsActive = true;
                }
                else
                {                   
                    if (bigMultiplierIsActive)
                    {
                        result += currentResult * bigMultiplierValue;
                        currentResult = 0;
                        bigMultiplierValue = 1;
                        bigMultiplierIsActive = false;
                    }
                    
                    int n;
                    if ((n = Array.IndexOf(ones, curword) + 1) > 0)
                    {
                        currentResult += n;
                    }
                    else if ((n = Array.IndexOf(teens, curword) + 1) > 0)
                    {
                        currentResult += n + 10;
                    }
                    else if ((n = Array.IndexOf(tens, curword) + 1) > 0)
                    {
                        currentResult += n * 10;
                    }                   
                    else if (minusWords.Contains(curword))
                    {
                        minusFlag = true;
                    }                   
                    else if (curword == "zero")
                    {
                        continue;
                    }
                    else if (int.TryParse(curword, out int tmp))
                    {
                        currentResult += tmp;
                    }
                    else if (curword != "and")
                    {
                        throw new ApplicationException("Expected a number: " + curword);
                    }
                }
            }

            var final = result + currentResult * bigMultiplierValue;
            if (minusFlag)
            {
                final *= -1;       
            }
            Console.WriteLine(final);
        }
    }
}
