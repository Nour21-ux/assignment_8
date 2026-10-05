using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_8
{
    public class Magazine:LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(int id, string title, int year, int issueNumber)
            : base(id, title, year)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[MAGAZINE] ID: {Id} | Title: \"{Title}\" | Year: {Year} | Issue #: {IssueNumber}");
        }
    }
}
