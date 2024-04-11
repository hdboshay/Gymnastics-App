using FinalProject.Models.DetailModels;

namespace FinalProject.Models.CompetitorModels;

internal class Competitor
{
    //defines the variables stored
    public string Name { get; set; }
    public int Bib { get; set; }
    public string Country { get; set; }
    public int CurrentRank { get; set; }
    public string TotalScore { get; set; }
    public Score FloorScore { get; set; }
    public Score VaultScore { get; set; }

    //empty constructor
    public Competitor()
    {
        CurrentRank = 0;
        TotalScore = string.Format("{0:f3}", 0);
        FloorScore = new Score();
        VaultScore = new Score();
    }

    public Competitor(string name, int bib, string country)
    {
        Name = name;
        Bib = bib;
        Country = country;
    }
}
