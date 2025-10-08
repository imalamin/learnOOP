class Program
{
    static void Main(string[] args)
    {
        Device myLaptop = new Laptop();
        Device myMobile = new Mobile();

        myLaptop.TurnOn();  // Output: Laptop is booting up.
        myMobile.TurnOn();  // Output: Mobile is starting.

    }
}

class Device
{

    public void TurnOn()
    {
        Console.WriteLine($" {Name} - Device is turned on.");
    }
}


class Laptop : Device
{
    public override TurnOn()
    {
        Console.WriteLine($" Laptop is booting up.");
    }
}

class Mobile : Device
{
    public override TurnOn()
    {
        Console.WriteLine($" Mobile is starting.");
    }
}