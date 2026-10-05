using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_8
{
    public static class LibraryUtilities
    {
        public static decimal CalculateLateFee(int overdueDays)
        {
            
            if (overdueDays <= 0) return 0.00m;

            decimal feePerDay = LibraryConfiguration.Instance.LateFeePerDay;
            return overdueDays * feePerDay;
        }

        public static string GenerateBookCode(string title, int id)
        {
            string prefix = title.Length >= 3 ? title.Substring(0, 3).ToUpper() : title.ToUpper();
            return $"{prefix}-{id}";
        }

        public static void PrintSeparator(string title = "")
        {
            Console.WriteLine();
            Console.WriteLine($"========== {title} ==========");
        }
    }
}
