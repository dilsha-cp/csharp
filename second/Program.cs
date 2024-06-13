namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone sphone = new SmartPhone("Samsung", "S21 FE", 20, "14");
            sphone.ShowDetails();
            sphone.StartDevice();
            sphone.UseDevice();


            FeaturePhone fphone = new FeaturePhone("Apple", "iphone", 30, 10);
            fphone.ShowDetails();
            fphone.StartDevice();
            fphone.UseDevice();

        }
    }
}
