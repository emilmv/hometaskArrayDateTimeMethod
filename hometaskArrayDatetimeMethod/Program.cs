using Microsoft.VisualBasic;
using System.Globalization;

namespace hometaskArrayDatetimeMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] reversedArray = new int[array.Length];

            //reverseArray(array, reversedArray);
            #endregion

            #region Task2
            DateTime currentDay = DateTime.Today;
            Console.WriteLine("Nece yashiniz oldugunu hesablayan program:");
            Console.WriteLine("===========================================");
        dateInput:
            Console.WriteLine("Xahish olunur dogum tarixinizi DD/MM/YYYY formatinda daxil edin:");

            bool isCorrectFormat = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("az-Latn-AZ"), DateTimeStyles.AssumeLocal, out DateTime birthday);

            if (!isCorrectFormat)
                goto dateInput;
            else
                Console.WriteLine($"Sizin - {myAge(birthday, currentDay)} yashiniz var");
            #endregion

            #region Task3
            //    Console.WriteLine("Verilmish ilin leap year olub-olmamasini tapan program");
            //    Console.WriteLine("========================================================");
            //yearInput:
            //    Console.WriteLine("Xahish olunur ili YYYY formatinda daxil edin:");

            //    bool isCorrectFormat = DateTime.TryParseExact(Console.ReadLine(),"yyyy", new CultureInfo("az-Latn-AZ"),DateTimeStyles.AssumeLocal, out DateTime inputDate);

            //    if (!isCorrectFormat)
            //        goto yearInput;
            //    else
            //        isLeapYear(inputDate);
            #endregion



        }
        static void reverseArray(int[] array, int[] reversedArray)
        {
            int index = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[index] += array[i];
                index++;

            }
            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.WriteLine(reversedArray[i]);
            }

        }

        static int myAge(DateTime birthday, DateTime currentDay)
        {
            int result = currentDay.Year-birthday.Year;
            if (currentDay.Month<birthday.Month)
                return result -= 1;
            if(currentDay.Month==birthday.Month)
            {
                if (currentDay.Day<birthday.Day)
                   return result -= 1;
                else if (currentDay.Day == birthday.Day)
                    return currentDay.Year-birthday.Year;
            }
            return result;
        }

        static void isLeapYear(DateTime inputDate)
        {
            int year=inputDate.Year;

            if (year % 4 == 0 && year % 100 != 0)
                Console.WriteLine($"{inputDate.Year} - leap year-dir.");
            else if(year % 400 == 0)
                Console.WriteLine($"{inputDate.Year} - leap year-dir");
            else
                Console.WriteLine($"{inputDate.Year} - leap year deyil.");
        }









    }

}
