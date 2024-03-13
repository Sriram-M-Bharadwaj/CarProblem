using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperWheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            Customer cust = new Customer() { Type = "Corporate" };
            Vehicle v = new Vehicle { Id = 101, SoldDate = 5, SoldMonth = "April" };
            c.Sell(v, cust);
            foreach (var var in c.Soldvehicles)
            {
                Console.WriteLine(var);
            }
        }
    }
    class Company
    {
        public List<Vehicle> Soldvehicles = new List<Vehicle>();
        Dictionary<String, int> dict = new Dictionary<String, int>() { ["January"] = 31, ["February"] = 29, ["March"] = 31, ["April"] = 30, ["May"] = 31, ["June"] = 30, ["July"] = 31, ["August"] = 31, ["September"] = 30, ["October"] = 31, ["November"] = 30, ["December"] = 31 };

        public void Sell(Vehicle v, Customer c)
        {
            if (v.SoldDate % 5 == 0)
            {
                if (c.Type == "Corporate")
                {
                    Console.WriteLine($"Vehicle {v.Id} sold ");
                    Soldvehicles.Add(v);
                }
                else
                {
                    Console.WriteLine("Cannot sell to Retail customer on this day");
                }
            }
            else
            {
                if (c.Type == "Retail")
                {
                    Console.WriteLine($"Vehicle {v.Id} sold ");
                    Soldvehicles.Add(v);
                }
            }

        }





    }
    class Customer
    {
        public string Type { get; set; }

    }
    class Vehicle
    {
        public int Id { get; set; }
        public int SoldDate { get; set; }
        public string SoldMonth { get; set; }


    }
}
