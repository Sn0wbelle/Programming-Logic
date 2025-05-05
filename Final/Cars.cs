public class Car : Vehicle
{
    public bool IsElectric { get; set; }

    public Car(string make, string model, int year, bool isElectric)
        : base(make, model, year)
    {
        IsElectric = isElectric;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Electric: {(IsElectric ? "Yes" : "No")}");
    }

    public void Register(string ownerName)
    {
        Console.WriteLine($"{Year} {Make} {Model} has been registered to {ownerName}.");
    }
}
