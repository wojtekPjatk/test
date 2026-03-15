// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


public abstract class Device
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public bool isAvailableToRent { get; set; }
    // public bool state (availableToRent, broken, notAvailable)
    public string StanZuzycia { get; set; }
    
    // kontruktor
    public void showAllItemsWithTheirState() {}
    public void showAllItemsAvailableToRent() {}
    
    public 
}

public class Laptop
{
    // kontruktor
}

public class Camera
{
    // kontruktor
}

public class Monitor
{
    // kontruktor
}

public abstract class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Type {get; set;}
    // Add new user (konstruktor metoda)
    
}

public class Student
{
    
}

public class Employee
{
    
}

public class Renting
{
    public long StartingDate { set; get; }
    public long PlannedEndDate { set; get; }
    public long RealEndDate { set; get; }
    public long Fee { set; get; }
    public long AdditionalCosts { set; get; }
    public long UserId { set; get; }
    public long DeviceId { set; get; }
    public bool WasReturnOnTime { set; get; }


    // Konstruktor, ktory pozwala wypozyczyc
    public void returnDevice(int DeviceId)
    {
        // check if return date extend planned end date. If it is true then calcualte additional costs
    }

    //public static showAllRentedDeviceForCertainUser(//userId) { }

    //public static showAllRentingObjectsWithNotReturnBeforeDeadline

    //public generateRaportAboutAllRentings() {
    // show current rentedObjects
    // show how many Objects where rentened to this date
    //}

}

public class Serwis
{
    
}

void main()
{
    // Add some items
}