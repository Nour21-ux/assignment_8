using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_8
{
    public abstract class LibraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public int Year { get; set; }

        protected LibraryItem(int id, string title, int year)
        {
            Id = id;
            Title = title;
            Year = year;
        }

        public abstract void DisplayInfo();

        public void PrintBasicInfo()
        {
            Console.WriteLine($"[ID: {Id}] Title: {Title} | Year: {Year}");
        }
    }

   
}
