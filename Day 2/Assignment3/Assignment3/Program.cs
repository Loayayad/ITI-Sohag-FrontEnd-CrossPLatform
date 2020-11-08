using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    class Program
    {
        static void Main(string[] args)
        {
            //A-
            //1-
            //Console.WriteLine("Enter an Hour..");
            //int hour = int.Parse(Console.ReadLine());

            //if (hour >= 0 && hour < 24)
            //{
            //    Console.WriteLine("The Hour entered is {0}", hour);
            //}
            //else
            //{
            //    hour = 0;
            //    Console.WriteLine("The hour is reset to zero");
            //}

            //Console.ReadLine();

            ////2-
            //int hour;
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Enter an Hour..");
            //    hour = int.Parse(Console.ReadLine());
            //    Console.WriteLine("The Hour entered is {0} \n", hour);
            //    i++;
            //} while (hour < 24 && i < 5);

            //Console.WriteLine("The program stopped");

            //Console.ReadLine();

            ////3-
            //for (int i = 0; i < 5; i++)
            //{
            //    int hour = 0;
            //    Console.WriteLine("Enter an Hour..");
            //    hour = int.Parse(Console.ReadLine());
            //    if (hour >= 0 && hour < 24)
            //    {
            //        Console.WriteLine("The Hour entered is {0} \n", hour);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try another hour.. \n");
            //    }
            //}

            //Console.WriteLine("The program stopped..");

            //Console.ReadLine();

            ////4-
            //for (int i = 0; i < 100; i++)
            //{
            //    int hour = 0;
            //    Console.WriteLine("Enter an Hour..");
            //    hour = int.Parse(Console.ReadLine());
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    if (hour >= 0 && hour < 24)
            //    {
            //        Console.WriteLine("The Hour entered is {0} \n", hour);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try another hour.. \n");
            //    }
            //}

            //Console.WriteLine("The program stopped..");

            //Console.ReadLine();

            ////5-
            //Console.WriteLine("Enter a Percent...");
            //int percent = int.Parse(Console.ReadLine());

            //try
            //{
            //    if (percent >= 0 && percent <= 100)
            //    {
            //        Console.WriteLine("The Percent entered is {0}", percent);
            //    }
            //    else
            //    {
            //        throw new IndexOutOfRangeException("The Entered percent is not valid ");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("the exception message is {0}", e.Message);
            //}

            //Console.ReadLine();


            //B-
            //1-

            Console.Write("Enter the Day : ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter the Year :");
            int year = int.Parse(Console.ReadLine());

            if ((year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
            {
                try
                {
                    if (day > 0 && day <= 366)
                    {


                        if (day > 0 && day <= 31)
                        {
                            Console.WriteLine("January {0}", day);
                        }
                        else if (day > 31 && day <= 60)
                        {

                            Console.WriteLine("February {0}", day - 31);
                        }
                        else if (day > 60 && day <= 91)
                        {
                            Console.WriteLine("March {0}", day - 60);
                        }
                        else if (day > 91 && day <= 121)
                        {
                            Console.WriteLine("April {0}", day - 91);
                        }
                        else if (day > 121 && day <= 152)
                        {
                            Console.WriteLine("May {0}", day - 121);
                        }
                        else if (day > 152 && day <= 182)
                        {
                            Console.WriteLine("June {0}", day - 152);
                        }
                        else if (day > 182 && day <= 213)
                        {
                            Console.WriteLine("July {0}", day - 182);
                        }
                        else if (day > 213 && day <= 244)
                        {
                            Console.WriteLine("August {0}", day - 213);
                        }
                        else if (day > 244 && day <= 274)
                        {
                            Console.WriteLine("September {0}", day - 244);
                        }
                        else if (day > 274 && day <= 305)
                        {
                            Console.WriteLine("October {0}", day - 274);
                        }
                        else if (day > 305 && day <= 335)
                        {
                            Console.WriteLine("November {0}", day - 305);
                        }
                        else if (day > 335 && day <= 366)
                        {
                            Console.WriteLine("December {0}", day - 335);
                        }

                    }
                    else
                    {
                        throw new ArgumentException("Day Out Of Range ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("the exception message is {0}", e.Message);
                }

                Console.WriteLine("{0} is Leap Year", year);
            }

            else
            {

                try
                {
                    if (day > 0 && day <= 366)
                    {
                        if (day > 0 && day <= 31)
                        {
                            Console.WriteLine("January {0}", day);
                        }
                        else if (day > 31 && day <= 60)
                        {

                            Console.WriteLine("February {0}", day - 31);
                        }
                        else if (day > 59 && day <= 90)
                        {
                            Console.WriteLine("March {0}", day - 59);
                        }
                        else if (day > 90 && day <= 120)
                        {
                            Console.WriteLine("April {0}", day - 90);
                        }
                        else if (day > 120 && day <= 151)
                        {
                            Console.WriteLine("May {0}", day - 120);
                        }
                        else if (day > 151 && day <= 181)
                        {
                            Console.WriteLine("June {0}", day - 151);
                        }
                        else if (day > 181 && day <= 212)
                        {
                            Console.WriteLine("July {0}", day - 181);
                        }
                        else if (day > 212 && day <= 243)
                        {
                            Console.WriteLine("August {0}", day - 212);
                        }
                        else if (day > 243 && day <= 273)
                        {
                            Console.WriteLine("September {0}", day - 243);
                        }
                        else if (day > 273 && day <= 304)
                        {
                            Console.WriteLine("October {0}", day - 273);
                        }
                        else if (day > 304 && day <= 334)
                        {
                            Console.WriteLine("November {0}", day - 304);
                        }
                        else if (day > 334 && day <= 365)
                        {
                            Console.WriteLine("December {0}", day - 334);
                        }

                    }
                    else
                    {
                        throw new ArgumentException("Day Out Of Range ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("the exception message is {0}", e.Message);
                }
                Console.WriteLine("{0} is not a Leap Year", year);
            }



            Console.ReadLine();

        }
    }
}
