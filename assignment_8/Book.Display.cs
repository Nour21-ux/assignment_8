using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_8
{
    public partial class Book
    {
        // --- Part 1 & 6: Display Methods ---
        public override void DisplayInfo()
        {
            Console.WriteLine($"[BOOK] ID: {Id} | Title: \"{Title}\" | Year: {Year} | Pages: {PageCount}");
        }

        public void PrintBookDetails()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Book Details for ID #{Id}:");
            Console.WriteLine($"  Title:      {Title}");
            Console.WriteLine($"  Published:  {Year}");
            Console.WriteLine($"  Page Count: {PageCount}");
            Console.WriteLine("----------------------------------------");
        }

    }
}
