using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        WebSite website = new WebSite();
        MobileApp mobileApp = new MobileApp();
        ManagerCall managerCall = new ManagerCall();

        Subscription sub1 = website.RegistrationSub("Premium");
        Subscription sub2 = mobileApp.RegistrationSub("Educational");
        Subscription sub3 = managerCall.RegistrationSub("Domestic");

        Console.WriteLine($"Website subscription: {sub1.MonthlyPrice},\nPeriod in month: {sub1.MinSubMonthlyPeriod}");
        Console.WriteLine($"Mobile app subscription: {sub2.MonthlyPrice},\nPeriod in month: {sub2.MinSubMonthlyPeriod}");
        Console.WriteLine($"Manager call subscription: {sub3.MonthlyPrice},\nPeriod in month: {sub3.MinSubMonthlyPeriod}");
    }
}
