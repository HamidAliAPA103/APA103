using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GenericTypesCollections.Models
{
    internal class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int PageCount { get; set; }


        public Book(int id,string title,string author,int year,int pagecount)
        {
            ID = id;
            Title = title;
            Author = author;
            Year = year;
            PageCount = pagecount;
             
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{ID} {Title } - {Author }{Year} - {PageCount} "); 
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
