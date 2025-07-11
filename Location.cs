public class Location : Adaptor
{
    public override void ExecuteCode()
    {
        Console.WriteLine("Executing Location code");
        throw new InvalidOperationException("Location not specified");
    }
    
}