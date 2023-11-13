// See https://aka.ms/new-console-template for more information
namespace DateAndTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime myDate = DateTime.Now;
             Console.WriteLine(myDate.ToString());
             Console.WriteLine(myDate.ToShortDateString()); 
             Console.WriteLine(myDate.ToShortTimeString());
             Console.WriteLine(myDate.ToLongDateString());
             Console.WriteLine(myDate.ToLongTimeString());
             Console.WriteLine(myDate.AddDays(3).ToLongDateString());
             Console.WriteLine(myDate.AddHours(3).ToLongTimeString());
             Console.WriteLine(myDate.AddDays(-3).ToLongDateString());
             Console.WriteLine(myDate.Month);
            */

            // to create future date

            //DateTime myBirthday = new DateTime(1970, 09, 15);

            DateTime myBirthday = DateTime.Parse("9/5/1970");

            //to check the time i've spent
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.WriteLine(myAge.TotalHours);
            Console.WriteLine(myAge.Minutes);

        }
    }
}

