using FinalProject.Models.DetailModels;

namespace FinalProject.Models.CompetitorModels;

internal class MaleCompetitor : Competitor
{
    //defines the variables stored
    public Score RingsScore { get; set; }
    public Score PommelHorseScore { get; set; }
    public Score ParallelBarsScore { get; set; }
    public Score HighBarScore { get; set; }

    //empty constructor
    public MaleCompetitor()
    {
        GenEmptyScores();
    }

    public MaleCompetitor(string name, int bib, string country)
    {
        Name = name;
        Bib = bib;
        Country = country;
        GenEmptyScores();
    }

    private void GenEmptyScores()
    {
        RingsScore = new Score();
        PommelHorseScore = new Score();
        ParallelBarsScore = new Score();
        HighBarScore = new Score();
    }

    public void UpdateTotalScore()
    {
        double floor = Convert.ToDouble(FloorScore.Total);
        double vault = Convert.ToDouble(VaultScore.Total);
        double rings = Convert.ToDouble(RingsScore.Total);
        double pommel = Convert.ToDouble(PommelHorseScore.Total);
        double pbars = Convert.ToDouble(ParallelBarsScore.Total);
        double highbar = Convert.ToDouble(HighBarScore.Total);

        TotalScore = string.Format("{0:f3}", (floor + vault + rings + pommel + pbars + highbar));
    }
}
