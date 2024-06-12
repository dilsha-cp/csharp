using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    interface Icamera
    {
        void TakePhoto();
    }
    interface Igps
    {
        void GetLocation();
    }
    public class Android : Mobile, Icamera, Igps
    {
        public void TakePhoto()
        {
            Console.WriteLine("photo");
        }
        public void GetLocation()
        {
            Console.WriteLine("location");
        }

        public Android(string brand,string model) : base(brand,model)
        {
        
        }
        public void installApp(string appName)
        {
            if(battery_level>20)
            {
                Console.WriteLine($"Installing app {appName}");
                UseBattery(5);
            }
            else
            {
                Console.WriteLine("Battery is not sufficent");
            }
        }


    }
}
