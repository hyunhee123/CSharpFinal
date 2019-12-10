/*
 * Source: https://docs.microsoft.com/en-us/dotnet/api/system.convert.changetype?view=netframework-4.8
 * Definition Source (mdoc): https://docs.microsoft.com/en-us/dotnet/
 * Author: Microsoft Docs
 * Summary: Returns an object of the specified type and whose value is equivalent to the specified object
 * Modifications: Changed the input.
 *                Added using System.
 */

using System;


public class ChangeTypeTest
{
    public static void Main()
    {
        
        Double d = 30.875;
        int i = (int)Convert.ChangeType(d, typeof(int));
        Console.WriteLine("The double value {0} when converted to an int becomes {1}", d, i);
        string s = "11/07/88";
        DateTime dt = (DateTime)Convert.ChangeType(s, typeof(DateTime));
        Console.WriteLine("The string value {0} when converted to a Date becomes {1}", s, dt);

    }
}

/* This code produces the following results:
The double value 30.875 when converted to an int becomse 31
The string value 11/07/88 when converted to a Date becomes 11/7/1988 12:00:00 AM
Press any key to continue...
*/
