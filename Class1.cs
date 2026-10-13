using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    enum Weekdays
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
    }
    class Class1
    {
        static void Main()
        {
            foreach(Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine(day);
            }

            Console.Write("What day of the week is it?");
            string dayInput = Console.ReadLine();

            switch (dayInput.ToLower())
            {
                case "monday":
                    Console.WriteLine("Monday is the first weekday!");
                    break;
                case "tuesday":
                    Console.WriteLine("Tuestday is the second weekday!");
                    break;
                case "wednesday":
                    Console.WriteLine("Wednesday is the third weekday!");
                    break;
                case "thursday":
                    Console.WriteLine("Thursday is the fourth weekday!");
                    break;
                case "friday":
                    Console.WriteLine("Friday is the fifth weekday!");
                    break;
                case "saturday":
                    Console.WriteLine("Saturday is the sixth weekday!");
                    Console.WriteLine("Saturday is a weekend day!");
                    break;
                case "sunday":
                    Console.WriteLine("Sunday is the seventh weekday!");
                    Console.WriteLine("Sunday is a weekend day!");
                    break;
                default:
                    Console.WriteLine("Please enter a valid day.");
                    break;
            }

            Console.Write("Please, enter the number of the day (from 1 to 7)");
            int number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 1:
                    Console.WriteLine(Weekdays.Monday);
                    break;
                case 2:
                    Console.WriteLine(Weekdays.Tuesday);
                    break;
                case 3:
                    Console.WriteLine(Weekdays.Wednesday);
                    break;
                case 4:
                    Console.WriteLine(Weekdays.Thursday);
                    break;
                case 5:
                    Console.WriteLine(Weekdays.Friday);
                    break;
                case 6:
                    Console.WriteLine(Weekdays.Saturday);
                    break;
                case 7:
                    Console.WriteLine(Weekdays.Sunday);
                    break;
                default:
                    Console.WriteLine("Please enter a number from 1 to 7!");
                    break;
            }
        }
        
    }
}
