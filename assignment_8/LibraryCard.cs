using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_8
{
    public sealed class LibraryCard
    {
        public string CardNumber { get; set; }
        public string MemberName { get; set; }
        public DateTime ExpirationDate { get; set; }

        public LibraryCard(string cardNumber, string memberName, DateTime expirationDate)
        {
            CardNumber = cardNumber;
            MemberName = memberName;
            ExpirationDate = expirationDate;
        }

        public void DisplayCard()
        {
            Console.WriteLine($"Library Card #{CardNumber} | Member: {MemberName} | Expires: {ExpirationDate:yyyy-MM-dd}");
        }
    }
}
