namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile myphone = new Mobile("Apple", "iphone 15");
            myphone.ChargeBattery(50);
            myphone.MakeCall("9995592263");
            myphone.UseBattery(20);
            myphone.PrintDetails();
            Android myphone1 = new Android("samsung", "s21");
            myphone1.ChargeBattery(40);
            myphone1.MakeCall("8157847663");
            myphone1.UseBattery(20);
            myphone1.PrintDetails();
            myphone1.installApp("valorent");
            myphone1.TakePhoto();
            myphone1.GetLocation();
           
        }
    }
}
