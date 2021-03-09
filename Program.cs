using System;

namespace DateTimeExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Get the date and time for the current moment, 
            //adjusted to the local time zone.
            DateTime saveNow = DateTime.Now;

            //Get the date and time for the current moment expressed
            //as coordinated universal time (UTC).
            DateTime saveUtcNow = DateTime.UtcNow;
            DateTime myDt;

            //Display the value and Kind property of the current moment
            //expressed as UTC and local time.
            DisplayDateTime.DisplayNow("UtcNow: ..........", saveUtcNow);
            DisplayDateTime.DisplayNow("Now: .............", saveNow);
            Console.WriteLine();

            //Change the Kind property of the current moment to
            //DateTimeKind.Utc and display the result.
            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Utc);
            DisplayDateTime.Display("Utc: .............", myDt);

            //Change the Kind property of the current moment to
            //DateTimeKind.Local and display the result.
            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
            DisplayDateTime.Display("Local: ...........", myDt);

            //Change the Kind property of the current moment to
            //DateTimeKind.Unspecified and display the result.
            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Unspecified);
            DisplayDateTime.Display("Unspecified: .....", myDt);
        }
    }
}
