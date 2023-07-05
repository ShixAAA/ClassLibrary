using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Шеховцов Иван 31ИС
            Store st = new Store("DNS Технопойнт", "улица Менжинского дом 55");
            st.products.Add(new Product("Беспроводная компьютерная мышь", 15));
            st.products.Add(new Product("Монитор MSI Optix G242", 3));
            st.products.Add(new Product("Компьютерный корпус Zalman I3", 10));
            st.ShowAll();
            Console.ReadKey();
        }
    }
}
