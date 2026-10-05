using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_8
{
    public partial class Book : LibraryItem, IComparable<Book>, ICloneable
    {
        public int PageCount { get; set; }

        public Book(int id, string title, int year, int pageCount)
            : base(id, title, year)
        {
            PageCount = pageCount;
        }

        // --- Part 2: IComparable<Book> Implementation ---
        public int CompareTo(Book? other)
        {
            if (other is null) return 1;

            
            int yearComparison = Year.CompareTo(other.Year);
            if (yearComparison != 0) return yearComparison;

            
            return string.Compare(Title, other.Title, StringComparison.OrdinalIgnoreCase);
        }

        // --- Part 3: ICloneable Implementation ---
        public object Clone()
        {
            
            return new Book(Id, Title, Year, PageCount);
        }

        // --- Part 7: Operator Overloading ---
        public static bool operator >(Book left, Book right)
        {
            return left.PageCount > right.PageCount;
        }

        public static bool operator <(Book left, Book right)
        {
            return left.PageCount < right.PageCount;
        }

        /*
         * Decision on '+' Operator:
         * Adding two books combines their page counts into a new "Collection" book.
         * The ID is generated as a new placeholder (-1), Year is set to the current year,
         * and titles are combined.
         */
        public static Book operator +(Book left, Book right)
        {
            int combinedPages = left.PageCount + right.PageCount;
            string combinedTitle = $"{left.Title} & {right.Title} (Volume Collection)";
            int newYear = DateTime.Now.Year;

            return new Book(-1, combinedTitle, newYear, combinedPages);
        }
    }
}
