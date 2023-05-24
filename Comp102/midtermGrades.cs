using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp102
{
    internal class midtermGrades
    {
        public void midtermMeth()
        {
            double quiz1;
            double lab1, lab2, lab3, lab4;
            double recit, hw, impt, sw;
            double handson, writex;
            double quiz, labact, others, exam, grade;

            Console.WriteLine("MIDTERM GRADE COMPUTATION");

        here:

            Console.Clear();
            Console.WriteLine("Enter your following grades:");
            Console.WriteLine("");

            Console.WriteLine("--Quiz--");
            Console.Write("Quiz 1: ");
            quiz1 = Convert.ToDouble(Console.ReadLine());
            quiz = ((quiz1 / 35) * 100);
            Console.WriteLine("");

            Console.WriteLine("--Lab Activities--");
            Console.Write("Lab Activity 1: ");
            lab1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lab Activity 2: ");
            lab2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lab Activity 3: ");
            lab3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lab Activity 4: ");
            lab4 = Convert.ToDouble(Console.ReadLine());
            labact = ((lab1 + lab2 + lab3 + lab4) / 4);
            Console.WriteLine("");

            Console.WriteLine("--Others--");
            Console.Write("Recitation: ");
            recit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Homework: ");
            hw = Convert.ToDouble(Console.ReadLine());
            Console.Write("Immunity Points: ");
            impt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Seatwork: ");
            sw = Convert.ToDouble(Console.ReadLine());
            others = (((recit + hw + impt + sw) / 210) * 100);
            Console.WriteLine("");

            Console.WriteLine("--Exam--");
            Console.Write("Hands-On Exam: ");
            handson = Convert.ToDouble(Console.ReadLine());
            Console.Write("Written Exam: ");
            writex = Convert.ToDouble(Console.ReadLine());
            exam = ((handson + writex) / 2);
            grade = ((quiz * 0.25) + (labact * 0.25) + (others * 0.20) + (exam *
            0.30));
            Console.WriteLine("");

            Console.WriteLine("Your Midterm Grade is " + Math.Round(grade));

            Console.WriteLine("Do you want to try again ? (Y / N) : ");
            char ans = Convert.ToChar(Console.ReadLine());

            if (ans == 'Y' || ans == 'y')
            {
                goto here;
            }

            else
            {
                Environment.Exit(0);
            }
        }
    }
}

