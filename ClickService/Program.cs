using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickService
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rightNumbers = new List<int>();
            Random random = new Random();
            int randomNumberInRange1 = random.Next(0, 9);
            int randomNumberInRange2 = random.Next(0, 9);
            int randomNumberInRange3 = random.Next(0, 9);
            rightNumbers.Add(randomNumberInRange1);
            rightNumbers.Add(randomNumberInRange2);
            rightNumbers.Add(randomNumberInRange3);

            while (true)
            {
                List<int> tryNumbers = new List<int>();
                Console.WriteLine("Enter 3 numbers: ");
                for (int i = 0; i < 3; i++)
                {
                    tryNumbers.Add(int.Parse(Console.ReadLine()));
                }

                int rightNumbersAtRightIndex = 0;
                int rightNumbersAtWrongIndex = 0;
                int wrongNumbers = 0;
                for (int i = 0; i < 3; i++)
                {
                    var currentNum = tryNumbers.ElementAt(i);
                    if (rightNumbers.Contains(currentNum))
                    {
                        if (rightNumbers.IndexOf(currentNum) == tryNumbers.IndexOf(currentNum))
                        {
                            rightNumbersAtRightIndex++;
                        }
                        else
                        {
                            rightNumbersAtWrongIndex++;
                        }
                    }
                    else
                    {
                        wrongNumbers++;
                    }
                }

                if (rightNumbersAtRightIndex == 3)
                {
                    Console.WriteLine("You win! You reveale the password!");
                    break;
                }
                Console.WriteLine("Right numbers at right index: " + rightNumbersAtRightIndex);
                Console.WriteLine("Right numbers at wrong index: " + rightNumbersAtWrongIndex);
                Console.WriteLine("Wrong numbers: " + wrongNumbers);
            }
        }
    }
}
