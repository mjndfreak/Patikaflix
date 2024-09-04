namespace Patikaflix;

public class ComedySeries 
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    
    public override string ToString()
    {
        return Name + " " + Genre + " " + Director;
    }
}