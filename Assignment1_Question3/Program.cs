using System;

namespace Assignment1_Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,1,1,3 };//Input of the array

            int gp = NumberOfPairs(arr);//Final output after calling function

            Console.WriteLine("The number of good paris are " + gp);
        }

        private static int NumberOfPairs(int[] MyArray)
        {
            int NumberOfPairs = 0;//Dummy variable to keep count of the number of good pairs
            try
            {
               

                for (int i = 0; i < MyArray.Length; i++)//iterating an index for an element in the loop
                {
                   
                    for (int j = i + 1; j < MyArray.Length; j++)//Creating J for comparing with other elements of the array
                    {
                        if (MyArray[i] == MyArray[j])//checking if the values are same
                        {
                            NumberOfPairs += 1;//if the values are same then we increment the pairs
                           
                        }

                    }

                }
            }
            catch
            {
                throw;
            }

            return NumberOfPairs;//returning the number of pairs

        }
        
    }

 }

