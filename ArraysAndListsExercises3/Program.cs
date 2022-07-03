using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2910726#content
/* 3 - Write a program that asks the user to enter 5 numbers. 
 * If a number has been previously entered, 
 * display an error message and ask the user to re-try. 
 * Once the user successfully enters 5 unique numbers, 
 * sort them and display the result on the console.*/
namespace ArraysAndListsExercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers: ");
            List<int> numberList = new List<int>();

            int i = 0;
            while (i < 5)
            {
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            numberList.Add(enteredNumber);
            i++;
            }
            Console.WriteLine();
            
            numberList.Sort();

            foreach (var n in numberList)
            {
            Console.WriteLine(n);
            }
        }
    }
}