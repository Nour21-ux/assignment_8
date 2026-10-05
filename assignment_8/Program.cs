namespace assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            // 1. Abstract Class & Polymorphism
            LibraryUtilities.PrintSeparator("Part 1: Abstract Class & Polymorphism");

            LibraryItem item1 = new Book(101, "Clean Code", 2008, 464);
            LibraryItem item2 = new Magazine(201, "National Geographic", 2023, 512);

            item1.DisplayInfo();      
            item2.DisplayInfo();      
            item1.PrintBasicInfo();   

            
            // 2. IComparable<T>
            LibraryUtilities.PrintSeparator("Part 2: IComparable<T> Sorting");

            List<Book> books = new List<Book>
            {
                new Book(1, "Clean Code", 2008, 464),
                new Book(2, "The Pragmatic Programmer", 1999, 352),
                new Book(3, "Design Patterns", 1994, 395),
                new Book(4, "C# in Depth", 2019, 528),
                new Book(5, "Refactoring", 1999, 448) 
            };

                     foreach (var b in books) b.DisplayInfo();

            books.Sort(); 

            foreach (var b in books) b.DisplayInfo();

            
            // 3. ICloneable
            LibraryUtilities.PrintSeparator("Part 3: ICloneable Interface");

            Book originalBook = new Book(10, "Clean Code", 2008, 464);
            Book clonedBook = (Book)originalBook.Clone();

            clonedBook.Title = "Clean Code - Copy";

            Console.WriteLine($"Original Book Title: {originalBook.Title}");
            Console.WriteLine($"Cloned Book Title:   {clonedBook.Title}");

            
            // 4. Static Class
            LibraryUtilities.PrintSeparator("Part 4: Static Utility Class");

            decimal fee = LibraryUtilities.CalculateLateFee(5);
            string code = LibraryUtilities.GenerateBookCode("Clean Code", 101);

            Console.WriteLine($"Late fee for 5 days: {fee:C}");
            Console.WriteLine($"Generated Book Code: {code}");

            
            // 5. Sealed Class
            LibraryUtilities.PrintSeparator("Part 5: Sealed Class");

            LibraryCard card = new LibraryCard("CARD-9988", "Nour Shabana", DateTime.Now.AddYears(1));
            card.DisplayCard();

           
            // 6. Partial Class
            LibraryUtilities.PrintSeparator("Part 6: Partial Class");

            Book partialBook = new Book(301, "Domain-Driven Design", 2003, 560);
            partialBook.DisplayInfo();       
            partialBook.PrintBookDetails();  

            
            // 7. Operator Overloading
            LibraryUtilities.PrintSeparator("Part 7: Operator Overloading");

            Book b1 = new Book(1, "Book One", 2020, 300);
            Book b2 = new Book(2, "Book Two", 2021, 500);

            if (b2 > b1)
            {
                Console.WriteLine($"\"{b2.Title}\" ({b2.PageCount} pages) has more pages than \"{b1.Title}\" ({b1.PageCount} pages).");
            }

            Book combinedBook = b1 + b2;
            Console.WriteLine($"Combined Book Title: \"{combinedBook.Title}\" | Total Pages: {combinedBook.PageCount}");

            
            // 8. Singleton Design Pattern
            LibraryUtilities.PrintSeparator("Part 8: Singleton Design Pattern");

            var config1 = LibraryConfiguration.Instance;
            var config2 = LibraryConfiguration.Instance;

            Console.WriteLine($"Library Name: {config1.LibraryName}");
            Console.WriteLine($"Max Borrow Days: {config1.MaximumBorrowDays}");
            Console.WriteLine($"Are config1 and config2 pointing to the exact same reference? {ReferenceEquals(config1, config2)}");



        }
    }
}
