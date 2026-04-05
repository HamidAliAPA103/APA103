using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GenericTypesCollections.Models
{
    internal class Library<T>
    {
        public List<T> Items { get; set; }

        public string Name { get; set; }

        public Library(string name)
        {
            Items = new List<T>();
            Name = name;
        }

        public void Add(T item)
        {
            Items.Add(item);
            Console.WriteLine($"Elave edildi:{item }");
        }

        public void Remove(T item)
        {
            Items.Remove(item);
            Console.WriteLine("Silindi");
        }
        public List<T> GetAll()
        {
            return Items;
        }

        public  int Count()
        {
            return Items .Count;
        }
        public T FindByIndex(int index)
        {
            if ( index < Items.Count )
            {
                return Items[index];
            }
            else
            {
                return default (T);
            }
        }
    }

}
