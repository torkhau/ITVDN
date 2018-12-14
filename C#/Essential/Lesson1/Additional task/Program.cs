using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    class Adresses
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public string Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adresses adress = new Adresses();
            adress.Index = "224002";
            adress.Country = "BY";
            adress.City = "Brest";
            adress.Street = "Zashitnikov Otechestva";
            adress.House = "2";
            adress.Apartment = "28";
            Console.WriteLine("Adress: {0}, {1}, {2}, {3}, {4} - {5}", adress.Country, adress.Index, adress.City, adress.Street, adress.House, adress.Apartment);
            Console.ReadKey();
        }
    }
}
