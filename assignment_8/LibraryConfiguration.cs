using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_8
{
    public sealed class LibraryConfiguration
    {
        // Thread-safe Lazy initialization guaranteed by the CLR
        private static readonly Lazy<LibraryConfiguration> _instance =
            new Lazy<LibraryConfiguration>(() => new LibraryConfiguration());

        public string LibraryName { get; set; }
        public int MaximumBorrowDays { get; set; }
        public decimal LateFeePerDay { get; set; }

        // Private constructor prevents external instantiation with 'new'
        private LibraryConfiguration()
        {
            LibraryName = "Central City Library";
            MaximumBorrowDays = 14;
            LateFeePerDay = 2.50m;
        }

        // Globally accessible static point of access
        public static LibraryConfiguration Instance => _instance.Value;
    }
}
