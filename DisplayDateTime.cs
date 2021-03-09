using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimeExamples
{
    public class DisplayDateTime
    {
        public static string datePatt = @"M/d/yyy hh:mm:ss tt";
        public static void Display(string title, DateTime inputDt)
        {
            DateTime dispDt = inputDt;
            string dtString;

            //Display the original DateTime.

            dtString = dispDt.ToString(datePatt);
            Console.WriteLine("{0} {1}, Kind = {2}",
                                title, dtString, dispDt.Kind);

            //Convert inputDt to local time and disply the result.
            //If inputDt.Kind is DateTimeKind.Utc, the conversion is performed.
            //If inputDt.Kind is DateTimeKind.Local, the conversion is not performed.
            //If inputDt.Kind is DateTimeKind.Unspecified, the conversion is
            //performed as if inputDt was universal time.
            dispDt = inputDt.ToUniversalTime();
            dtString = dispDt.ToString(datePatt);
            Console.WriteLine(" ToUniversalTime: {0}, Kind = {1}",
                              dtString, dispDt.Kind);
            Console.WriteLine();
        }

        public static void DisplayNow(string title, DateTime inputDt)
        {
            string dtString = inputDt.ToString(datePatt);
            Console.WriteLine("{0} {1}, Kind = {2}",
                               title, dtString, inputDt.Kind);
        }
    }
}
