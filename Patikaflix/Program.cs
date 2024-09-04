using Patikaflix;





List<TvSeries> tvSeries = new List<TvSeries>()
{
        new TvSeries()
        {
                Name = "Avrupa Yakası", ProductionYear = 2004, Genre = "Comedy", DebutYear = 2004, Director = "Yüksel Aksu", firstTv = "Kanal D"
        },
        new TvSeries()
        {
                Name = "Yalan Dünya", ProductionYear = 2012, Genre = "Comedy", DebutYear = 2012, Director = "Güsleren Buda Başkaya", firstTv = "Fox TV"
        },
        new TvSeries()
        {
                Name = "Jet Sosyete", ProductionYear = 2018, Genre = "Comedy", DebutYear = 2018, Director = "Güsleren Buda Başkaya", firstTv = "TV8"
        },
        new TvSeries()
        {
                Name = "Dadı", ProductionYear = 2006, Genre = "Comedy", DebutYear = 2006, Director = "Yusuf Pirhasan", firstTv = "Kanal D"
        },
        new TvSeries()
        {
                Name = "Belalı Baldız", ProductionYear = 2007, Genre = "Comedy", DebutYear = 2007, Director = "Yüksel Aksu", firstTv = "Kanal D"
        },
        new TvSeries()
        {
                Name = "Arka Sokaklar", ProductionYear = 2004, Genre = "Detective/Drama", DebutYear = 2004, Director = "Orhan Oğuz", firstTv = "Kanal D"
        },
        new TvSeries()
        {
                Name = "Aşk-ı Memnu", ProductionYear = 2008, Genre = "Drama/Romantic", DebutYear = 2008, Director = "Hilal Saral", firstTv = "Kanal D"
        },
        new TvSeries()
        {
                Name = "Muhteşem Yüzyıl", ProductionYear = 2011, Genre = "History/Drama", DebutYear = 2011, Director = "Mercan Çilingiroğlu", firstTv = "Star TV"
        },
        new TvSeries()
        {
                Name = "Yaprak Dökümü", ProductionYear = 2006, Genre = "Drama", DebutYear = 2006, Director = "Serdar Akar", firstTv = "Kanal D"
        }
};

while (true)
{
        Console.Write("Do you want to add a song ? (y/n)");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
                TvSeries s = new TvSeries();
                Console.Write("Name:");
                s.Name = Console.ReadLine();
                Console.Write("ProductionYear:");
                s.ProductionYear = int.Parse(Console.ReadLine());
                Console.Write("Genre:");
                s.Genre = Console.ReadLine();
                Console.Write("Debut Year:");
                s.DebutYear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Director:");
                s.Director = Console.ReadLine();
                Console.Write("First Tv Channel:");
                s.firstTv = Console.ReadLine();
                
        }
        else
        {
                break;
        }
}


List<ComedySeries> comedySeries = new List<ComedySeries>();
var comedy = tvSeries.Where(s => s.Genre.Contains("Comedy"));
foreach (var s in comedy)
{
        comedySeries.Add(s);
}


foreach (var series in tvSeries)
{
        Console.WriteLine(series);
}

Console.WriteLine("-------------------");


foreach (var series in comedySeries)
{
        Console.WriteLine(series.ToString());
}