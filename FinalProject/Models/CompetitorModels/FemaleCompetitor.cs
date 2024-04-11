using FinalProject.Models.DetailModels;

namespace FinalProject.Models.CompetitorModels;

internal class FemaleCompetitor : Competitor
{
    //defines the variables stored
    public Score BeamScore { get; set; }
    public Score UnevenBarsScore { get; set; }

    //empty constructor
    public FemaleCompetitor()
    {
        GenEmptyScores();
    }

    public FemaleCompetitor(string name, int bib, string country)
    {
        Name = name;
        Bib = bib;
        Country = country;
        GenEmptyScores();
    }

    private void GenEmptyScores()
    {
        BeamScore = new Score();
        UnevenBarsScore = new Score();
    }

    public void UpdateTotalScore()
    {
        double floor = Convert.ToDouble(FloorScore.Total);
        double vault = Convert.ToDouble(VaultScore.Total);
        double beam = Convert.ToDouble(BeamScore.Total);
        double bars = Convert.ToDouble(UnevenBarsScore.Total);

        TotalScore = string.Format("{0:f3}", (floor + vault + beam + bars));
    }
}