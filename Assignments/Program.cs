using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Assignment 6



            //int[][] studentScores = new int[3][];
            //studentScores[0] = new int[] { 85, 92, 78 };
            //studentScores[1] = new int[] { 90, 87, 93, 89 };
            //studentScores[2] = new int[] { 76, 88 };
            //Console.WriteLine("Student Scores:");
            //for (int i = 0; i < studentScores.Length; i++)
            //{
            //    Console.Write("Student {0}: ", i + 1);
            //    for (int j = 0; j < studentScores[i].Length; j++)
            //    {
            //        Console.Write("{0} ", studentScores[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\nAverage Scores:");
            //for (int i = 0; i < studentScores.Length; i++)
            //{
            //    double sum = 0;
            //    for (int j = 0; j < studentScores[i].Length; j++)
            //    {
            //        sum += studentScores[i][j];
            //    }
            //    double average = sum / studentScores[i].Length;
            //    Console.WriteLine("Student {0}: {1}", i + 1, average);
            //}
            //Console.WriteLine("\nAverage Score for All Students:");
            //double totalSum = 0;
            //double totalCount = 0;
            //for (int i = 0; i < studentScores.Length; i++)
            //{
            //    for (int j = 0; j < studentScores[i].Length; j++)
            //    {
            //        totalSum += studentScores[i][j];
            //        totalCount++;
            //    }
            //}
            //double totalAverage = totalSum / totalCount;
            //Console.WriteLine(totalAverage);







            //Assignment 7



            // Create an ArrayList
            ArrayList fruits = new ArrayList();

            // Add elements to the ArrayList based on user input
            Console.WriteLine("Enter fruits (one per line, empty line to stop):");
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                fruits.Add(input);
            }

            // Print the total number of elements in the ArrayList
            Console.WriteLine("Total number of elements: " + fruits.Count);

            // Check if the ArrayList contains the element "date"
            Console.WriteLine("ArrayList contains 'date': " + fruits.Contains("date"));

            // Insert the element "fig" at the second position in the ArrayList
            Console.WriteLine("Enter the fruit to insert:");
            string fruitToInsert = Console.ReadLine();
            Console.WriteLine("Enter the index to insert at:");
            int insertIndex = int.Parse(Console.ReadLine());
            fruits.Insert(insertIndex, fruitToInsert);

            // Remove the element "banana" from the ArrayList
            Console.WriteLine("Enter the fruit to remove:");
            string fruitToRemove = Console.ReadLine();
            fruits.Remove(fruitToRemove);

            // Print all the elements in the ArrayList using a loop
            Console.WriteLine("Elements in the ArrayList:");
            foreach (object fruit in fruits)
            {
                Console.WriteLine(fruit);

            }
        }

    }
}
