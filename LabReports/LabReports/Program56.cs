/*write a C# program to creat a class Time which represent time.The Class should have 
 * three fields for hours,minutes and seconds. 
It should have constructor to initialized the hours,
minutes and seconds and method displayTime() to print the current time.
Overload the following operators:
+(add two time object based on 24 hour clock)
< (compare two time object)*/
using System;

class Time
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public void DisplayTime()
    {
        Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");
    }

    public static Time operator +(Time time1, Time time2)
    {
        int totalSeconds = time1.Hours * 3600 + time1.Minutes * 60 + time1.Seconds +
                           time2.Hours * 3600 + time2.Minutes * 60 + time2.Seconds;
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;
        return new Time(hours, minutes, seconds);
    }

    public static bool operator <(Time time1, Time time2)
    {
        int totalSeconds1 = time1.Hours * 3600 + time1.Minutes * 60 + time1.Seconds;
        int totalSeconds2 = time2.Hours * 3600 + time2.Minutes * 60 + time2.Seconds;
        return totalSeconds1 < totalSeconds2;
    }

    public static bool operator >(Time time1, Time time2)
    {
        int totalSeconds1 = time1.Hours * 3600 + time1.Minutes * 60 + time1.Seconds;
        int totalSeconds2 = time2.Hours * 3600 + time2.Minutes * 60 + time2.Seconds;
        return totalSeconds1 > totalSeconds2;
    }
}

class Program56
{
    static void Main(string[] args)
    {
        Time time1 = new Time(2, 30, 0);
        Time time2 = new Time(3, 30, 9);
        Time time3 = time1 + time2;
        time3.DisplayTime();

        if (time1 < time2)
        {
            Console.WriteLine("time1 is less than time2");
        }
        else if (time1 > time2)
        {
            Console.WriteLine("time1 is greater than time2");
        }
        else
        {
            Console.WriteLine("time1 is equal to time2");
        }
    }
}
