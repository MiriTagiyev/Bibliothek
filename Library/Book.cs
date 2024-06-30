using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyLibrary.ElementClasses
{
	public class Book
	{
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
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
                status =  "Magazada var";
			}
			return $"Kitab adı: {BookName} || Yazıçı: {Author} || Nəşriyyar ili: {Year} || Janrı: {Type} || Statusu: {status}";
		}


	}
}
