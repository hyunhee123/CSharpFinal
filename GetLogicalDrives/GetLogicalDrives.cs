/*
 * Source: https://docs.microsoft.com/en-us/dotnet/api/system.environment.getlogicaldrives?view=netframework-4.8
 * Definition Source (mdoc): https://docs.microsoft.com/en-us/dotnet/
 * Author: Microsoft Docs
 * Summary: Returns an array of string containing the names of the logical drives on the current computer.
 * Modifications: Added using System.
 */

using System;


public class GetLogicalDrives
{
    public static void Main()
    {
        
        Console.WriteLine();
        String[] drives = Environment.GetLogicalDrives();
        Console.WriteLine("GetLogicalDrives: {0}", String.Join(", ", drives));
    }
}

/* This code produces the following results:
GetLogicalDrives: C:\, H:\, P:\
Press any key to continue...
*/
