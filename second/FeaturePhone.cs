using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    public class FeaturePhone : Mobile
    {
        private int buttonCount;

        public FeaturePhone(string brand, string model, int battery_level, int buttonCount) : base(brand, model, battery_level)
        {
            this.buttonCount = buttonCount;
        }
        public override void StartDevice()
        {
            Console.WriteLine("FeaturePhone has started device");
        }
        public override void UseDevice()
        {
            Console.WriteLine("FeaturePhone is using the device..");
        }
        public void showDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Button count : {buttonCount}");
        }

    }
}
