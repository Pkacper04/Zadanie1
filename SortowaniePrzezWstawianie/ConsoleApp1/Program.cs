using System;

namespace SortowaniePrzezWybieranie
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] randomNumbers = GenerateNumbers();
            DisplayArray(randomNumbers, "AR");
            InsertSort(randomNumbers);
        }

        #region Calculating Methods

        static int[] GenerateNumbers()
        {
            Random rand = new Random();
            int[] tempArray = new int[100];
            for (int i = 0; i < 100; i++)
            {
                tempArray[i] = rand.Next(1, 101);
            }
            return tempArray;
        }

        static void SelectionSort(ref int[] userArray)
        {
            for (int i = 0; i < userArray.Length - 1; i++)
            {
                for (int j = i + 1; j < userArray.Length; j++)
                {
                    if (userArray[i] > userArray[j])
                    {
                        (userArray[i], userArray[j]) = (userArray[j], userArray[i]);
                    }
                }
            }
        }

        static void InsertSort(int[] userArray)
        {
            int[] temporaryArray = new int[userArray.Length];

            for (int i = 0; i < userArray.Length; i++)
            {
                for (int j = 0; j < temporaryArray.Length - 1; j++)
                {
                    if (temporaryArray[j] == 0)
                    {
                        temporaryArray[j] = userArray[i];
                        break;
                    }
                    else if (temporaryArray[j] < userArray[i] && temporaryArray[j + 1] > userArray[i])
                    {
                        InsertValue(ref temporaryArray, j, userArray[i]);
                        break;
                    }
                }
            }

            DisplayArray(temporaryArray, "Array: ");
        }

        private static void InsertValue(ref int[] temporaryArray, int index, int value)
        {
            for (int i = temporaryArray.Length - 1; i >= index; i--)
            {
                if (temporaryArray[i] == 0)
                    continue;

                temporaryArray[i + 1] = temporaryArray[i];
            }
            temporaryArray[index] = value;
        }

        #endregion Calculating Methods

        #region Displaying Methods

        static void DisplayArray(int[] userArray, string prefix, int numbersOfNewLinesBefore = 0)
        {
            for (int i = 0; i < numbersOfNewLinesBefore; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine(prefix);
            foreach (int number in userArray)
            {
                Console.Write(number + ",");
            }
        }

        #endregion Displaying Methods
    }
}
