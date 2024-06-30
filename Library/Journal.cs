using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.ElementClasses
{
    public class Journal
    {
        public string  JournalName { get; set; }
        public string JournalType { get; set; }
        public int Year { get; set; }
        public bool IsRented { get; set; }

        public override string ToString()
        {
            string status;
            if (IsRented)
            {
                status = "Kirayelenib";
            }
            else
            {
                status = "Magazada var";
            }
            return $"Jurnal adı: {JournalName} || Tipi: {JournalType} || Nəşriyyar ili: {Year} || Statusu: {status}";
        }
    }
}
