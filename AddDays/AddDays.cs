/*
 * Source: https://docs.microsoft.com/en-us/dotnet/api/system.datetime.adddays?view=netframework-4.8
 * Definition Source (mdoc): https://docs.microsoft.com/en-us/dotnet/
 * Author: Microsoft Docs
 * Summary: Returns a new DateTime that adds the specified number of days to the value of this instance.
 * Modifications: Changed the input.
 *                Added using System.
 */

using System;


public class AddDays
{
    public static void Main()
    {
        DateTime today = DateTime.Now;
        DateTime answer = today.AddDays(36);
        Console.WriteLine("Today: {0:dddd}", today);
        Console.WriteLine("36 days from today: {0:dddd}", answer);
    }
}

/* This code produces the following results:
Today: Monday
36 days from today: Tuesday
Press any key to continue....
*/
