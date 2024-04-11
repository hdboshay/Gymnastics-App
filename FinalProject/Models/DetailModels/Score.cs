namespace FinalProject.Models.DetailModels;

internal class Score
{
    public double Difficulty { get; set; }
    public double Exectuion { get; set; }
    public double Penalty { get; set; }
    public string Total { get; set; }

    public Score()
    {
        Difficulty = 0;
        Exectuion = 0;
        Penalty = 0;
        Total = string.Format("{0:f3}", 0);
    }

    public Score(double diff, double ex, double pen)
    {
        Difficulty = diff;
        Exectuion = ex;
        Penalty = pen;
        Total = string.Format("{0:f3}", (Math.Round(Difficulty + Exectuion + Penalty, 3)));
    }
}
