using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Product> products = new List<Product>();

        public Store(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void ShowAll() 
        {
            //Шеховцов Иван 31ИС
            Console.WriteLine($"Склад: название = {Name}, адрес: {Address}");
            products.Sort();
            foreach (Product products in products)
            {
                products.Show();
            }
        }
    }
}
