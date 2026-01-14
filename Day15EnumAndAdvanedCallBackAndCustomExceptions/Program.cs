﻿using System;

namespace Day15
{
    public class Example_Enum
    {
        public delegate void Notify();  // delegate
        public static event Notify Reached500; // event
        public static void Main()
        {

            #region Enum Example1
            //WeekDays today = WeekDays.Wednesday;
            //Console.WriteLine("Today is: " + today);

            //int enumValue = (int)WeekDays.Friday;
            //ProductCategory category = ProductCategory.Electronics;
            //Console.WriteLine("Selected category: " + category + " with value " + (int)category);


            //     int numValuePara = 0;
            //     string variableForDay = GetWeekDay(WeekDays.Thursday, ref numValuePara);
            //     Console.WriteLine(variableForDay);
            //     Console.WriteLine(numValuePara);
            // }
            // public static string GetWeekDay(WeekDays weekDays, ref int numValue)
            // {
            //     numValue = (int)weekDays;
            //     return weekDays.ToString();
            // }

            // public static String MenuByDay(WeekDays day)
            // {
            //     switch (day)
            //     {
            //         case WeekDays.Monday:
            //             return "Pasta";
            //         case WeekDays.Tuesday:
            //             return "Tacos";
            //         case WeekDays.Wednesday:
            //             return "Chicken Curry";
            //         case WeekDays.Thursday:
            //             return "Pizza";
            //         case WeekDays.Friday:
            //             return "Fish and Chips";
            //         case WeekDays.Saturday:
            //             return "Burgers";
            //         case WeekDays.Sunday:
            //             return "Roast Dinner";
            //         default:
            //             return "Unknown Day";
            //     }
            // }
            #endregion

            #region AdvancedCallBack-part1
            // var service = new OrderService();
            // Pass a method as callback
            // service.PlaceOrder("ORD-101", SendEmail);

            // // Pass another method as callback
            // service.PlaceOrder("ORD-102", SendSms);
            #endregion

            #region Custom Exceptions
            // try
            // {
            //     int result = Divide(10, 0);
            // }
            // catch(CustomException ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }

            #endregion

            #region Event example

            while (true)
            {
                Console.WriteLine("Enter a number (or 'exit' to quit): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
                try
                {
                    Console.WriteLine("Enter value a Value ");
                    var num = int.Parse(Console.ReadLine());
                    if (num > 500)
                    {
                        Reached500 = ValueReached500Plus;
                        Reached500();
                    }
                    num = 0;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            #endregion
        }

            #region Event Example
            private static void ValueReached500Plus()
        {
            Console.WriteLine("Yes Reached 500 or 500 plus please note");
        }
            #endregion




        #region AdvancedCallBack-part2
        // static void SendEmail(string msg) => Console.WriteLine("EMAIL: " + msg);
        // static void SendSms(string msg) => Console.WriteLine("SMS:   " + msg);
        #endregion

        #region Custom Exceptions

        public static int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                throw new CustomException();
            }
        }
        #endregion
    }
}
