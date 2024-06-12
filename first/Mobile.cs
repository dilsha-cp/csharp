using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class Mobile
    {
        //attributes
        public string brand;
        public string model;
        public int battery_level;
        public Mobile(string brand,string model) 
        {
            this.brand = brand;
            this.model = model;
            this.battery_level = 0;
        }
        public void MakeCall(string phoneNo)
        {
            Console.WriteLine(phoneNo);
            Console.WriteLine("\nMaking a call");
            UseBattery(10);
        }
        public void ChargeBattery(int amount) {
            battery_level += amount;
            if (battery_level > 100) 
            {
                battery_level = 100;
            }
            Console.WriteLine($"battery charged to {battery_level}%");
        }
        public void UseBattery(int amount)
        {
            battery_level -= amount;
            if (battery_level < 0)
            {
                battery_level = 0;
            }
            Console.WriteLine($"Battery level:{battery_level}%");
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Brand:{brand}");
            Console.WriteLine($"Model:{model}");
            Console.WriteLine($"Battery Level:{battery_level}%");
        }

    }
}
