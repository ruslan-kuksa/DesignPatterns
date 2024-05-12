using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Runway runway1 = new Runway();
        Runway runway2 = new Runway();
        Aircraft aircraft1 = new Aircraft("Boeing 747");
        Aircraft aircraft2 = new Aircraft("Airbus A320");

        CommandCentre control = new CommandCentre(new Runway[] { runway1, runway2 }, new Aircraft[] { aircraft1, aircraft2 });

        control.RequestLand(aircraft1);
        control.RequestTakeOff(aircraft1);
        control.RequestLand(aircraft2);
        control.RequestTakeOff(aircraft2);
    }
}