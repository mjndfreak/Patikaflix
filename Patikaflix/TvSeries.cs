namespace Patikaflix;

public class TvSeries : ComedySeries
{
    
    public int ProductionYear { get; set; }
    public int DebutYear { get; set; }
    
    public string firstTv { get; set; }

    public override string ToString()
    {
        return Name + " " + Genre + " " + ProductionYear + " " + Director + " " + DebutYear + " " + firstTv;
    }
}