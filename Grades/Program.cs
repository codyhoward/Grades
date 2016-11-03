using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChanged;
            
            book.Name = "Cody's Grade Book";
            book.Name = "A Very Simple Program Coming Together";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);

        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            Console.WriteLine(textInfo.ToTitleCase($"Grade book changing name from {args.ExistingName} to {args.NewName}"));
            //reworked to use events instead of solely using the delegate. 

        } //Delegate calls OnNameChanged and writes the above

            static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }

    }
}