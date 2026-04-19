/*
 * Program: Student Grade Classification
 * 
 * Description:
 * This program takes a student's score and classifies it into grades.
 * 
 * Input: Score (0 - 100)
 * Output: Grade (A, B, C, D, F)
 * 
 * Criteria:
 * A: 90 - 100
 * B: 80 - 89
 * C: 70 - 79
 * D: 60 - 69
 * F: 0 - 59
 * 
 * Logic:
 * 1. Take input score
 * 2. Validate score (0 to 100)
 * 3. Use if-else conditions:
 *      - >= 90 → A
 *      - >= 80 → B
 *      - >= 70 → C
 *      - >= 60 → D
 *      - else → F
 */

using System;

namespace basic_code
{
    internal class GradeCalculator
    {
        internal void CalculateGrade()
        {
            Console.Write("Enter student score (0-100): ");

            if (!int.TryParse(Console.ReadLine(), out int score) || score < 0 || score > 100)
            {
                Console.WriteLine("Invalid input. Score must be between 0 and 100.");
                return;
            }

            char grade;

            if (score >= 90)
                grade = 'A';
            else if (score >= 80)
                grade = 'B';
            else if (score >= 70)
                grade = 'C';
            else if (score >= 60)
                grade = 'D';
            else
                grade = 'F';

            Console.WriteLine("Grade: " + grade);
        }
    }
}