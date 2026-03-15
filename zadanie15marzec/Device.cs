namespace zadanie15marzec;

public class Device
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string StanZuzycia { get; set; }
    //public bool isAvailableToRent { get; set; }
    // public bool state (availableToRent, broken, notAvailable)

    public Device(int id, string name, string stanZuzycia)
    {
        Id = id;
        Name = name;
        StanZuzycia = stanZuzycia;
        
    }
    
    
    
    public void showAllItemsWithTheirState() {}
    public void showAllItemsAvailableToRent() {}
}
