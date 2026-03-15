namespace zadanie15marzec;

public class Laptop : Device
{
    public string ProcessorName { get; set; }
    public string RamSize { get; set; }
    public string OperatingSystemName { get; set; }

    public Laptop(int id, string name, string stanZuzycia, string processorName, string ramSize, string operatingSystemName) : base(id, name, stanZuzycia)
    {
        
    }
}

