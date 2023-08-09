using System;

namespace ConsoleApp_Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberofStudent = 1;
            int[] midScore, finalScore, sumScore;
            string[] studentName;

            Console.Write("How many students? : ");
            numberofStudent = int.Parse(Console.ReadLine());

            studentName = new string[numberofStudent];
            midScore = new int[numberofStudent];
            finalScore = new int[numberofStudent];
            sumScore = new int[numberofStudent];

            Console.WriteLine(":: Student Information ::");
            for (int zui = 0; zui < numberofStudent; zui++)
            {
                Console.Write($"\nPlease key student({zui + 1} of {numberofStudent}) name : ");
                studentName[zui] = Console.ReadLine();

                Console.Write($"Please key {studentName[zui]}'s middle score : ");
                midScore[zui] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {studentName[zui]}'s final score : ");
                finalScore[zui] = Convert.ToInt32(Console.ReadLine());

                sumScore[zui] = midScore[zui] + finalScore[zui];
            }

            Console.WriteLine("\n:: List of students and grades ::");
            int _iterator = 0;

            do
            {
                float gradesScore = 0.0f;


                if (sumScore[_iterator] <= 49) gradesScore = 0f;
                else if (sumScore[_iterator] <= 54) gradesScore = 1f;
                else if (sumScore[_iterator] <= 59) gradesScore = 1.5f;
                else if (sumScore[_iterator] <= 64) gradesScore = 2f;
                else if (sumScore[_iterator] <= 69) gradesScore = 2.5f;
                else if (sumScore[_iterator] <= 74) gradesScore = 3f;
                else if (sumScore[_iterator] <= 79) gradesScore = 3.5f;
                else if (sumScore[_iterator] >= 80) gradesScore = 4f;

                Console.WriteLine($"{_iterator + 1}. {studentName[_iterator]} have a" +
                                $" total {sumScore[_iterator]} score or {gradesScore} grades.");
                _iterator++;
            } while (_iterator < numberofStudent);

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}