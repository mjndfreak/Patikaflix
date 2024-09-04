namespace Patikaflix;

public class TvSeries : Series
{
    
    

    public override string ToString()
    {
        return Name + " " + Genre + " " + ProductionYear + " " + Director + " " + DebutYear + " " + firstTv;
    }
}