using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * DSA Activity 3.1 - [Cabasal, Ashton Lysander]
             * Program Description: Array of Scores
             * Accept 10 scores, display the scores,
             * calculate the average, and display a remark.
             */
            //some changes of code

            int[] scores = new int[10];
            int sum = 0;

            // Input 10 scores
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter score " + (i + 1) + ": ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                sum += scores[i];
            }

            // Display scores
            Console.WriteLine();
            Console.Write("Scores: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(scores[i] + " ");
            }

            // Calculate average
            int average = sum / 10;

            Console.WriteLine();
            Console.WriteLine("Average score is " + average);

            // Display remark
            string remark;

            if (average >= 4)
            {
                remark = "Excellent";
            }
            else if (average >= 3)
            {
                remark = "Good";
            }
            else if (average >= 2)
            {
                remark = "Fair";
            }
            else
            {
                remark = "Poor";

                Console.WriteLine("Remark: " + remark);
            }
        }
    }
}