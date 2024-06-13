using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    public class SmartPhone : Mobile
    {
        private string osVersion;
        public SmartPhone(string brand, string model, int battery_level, string osVersion) : base(brand, model, battery_level)
        {
            this.osVersion = osVersion;
        }
        public override void StartDevice()
        {
            Console.WriteLine("Device has started");
        }
        public override void UseDevice()
        {
            Console.WriteLine("Device has started");
        }
        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Os version : {osVersion}");


        }
    }
}
