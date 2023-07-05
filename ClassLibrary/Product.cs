using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product:IComparable<Product>
    {
        public string Name { get; set; }
        public int Number { get; set; }
        //Шеховцов Иван 31ИС

        public Product(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public void Show() 
        {
            //Шеховцов Иван 31ИС
            Console.WriteLine($"\tПродукт: имя = {Name}, количество = {Number}");
        }

        public int CompareTo(Product other) 
        {
            return Name.CompareTo(other.Name);
        }
    }
}
