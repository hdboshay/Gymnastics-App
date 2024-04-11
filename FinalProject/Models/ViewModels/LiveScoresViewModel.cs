using CommunityToolkit.Mvvm.ComponentModel;
using FinalProject.Models.CompetitorModels;
using FinalProject.Models.DetailModels;
using System.Collections.ObjectModel;

namespace FinalProject.Models.ViewModels;

internal partial class LiveScoresViewModel : ObservableObject
{
    //constructor
    public LiveScoresViewModel()
    {
        Competitors = new ObservableCollection<MaleCompetitor>();
        GetCompetitors();
    }

    [ObservableProperty]
    ObservableCollection<MaleCompetitor> competitors;

    [ObservableProperty]
    private int currentRank;

    [ObservableProperty]
    private string bib;

    [ObservableProperty]
    private string name;

    [ObservableProperty]
    private string country;

    [ObservableProperty]
    private float totalScore;

    [ObservableProperty]
    private Score floorScore;

    [ObservableProperty]
    private Score vaultScore;

    [ObservableProperty]
    private Score ringsScore;

    [ObservableProperty]
    private Score pommelHorseScore;

    [ObservableProperty]
    private Score parallelBarsScore;

    [ObservableProperty]
    private Score highBarScore;

    public void GetCompetitors()
    {
        Competitors = GenCompetitors();
    }

    public ObservableCollection<MaleCompetitor> GenCompetitors()
    {
        //all scores taken from world champs 2023 all round finals as example data
        MaleCompetitor gymnast1 = new MaleCompetitor("HALL James", 186, "GBR");
        gymnast1.FloorScore = new Score(5.8, 7.8, -0);
        gymnast1.PommelHorseScore = new Score(5.4, 7.9, -0);
        gymnast1.RingsScore = new Score(5.2, 8.366, -0);
        gymnast1.VaultScore = new Score(4.8, 8.933, -0);
        gymnast1.ParallelBarsScore = new Score(6.1, 8.566, -0);
        gymnast1.HighBarScore = new Score(5.4, 8.066, -0);
        gymnast1.UpdateTotalScore();

        MaleCompetitor gymnast2 = new MaleCompetitor("HASHIMOTO Daiki", 228, "JPN");
        gymnast2.FloorScore = new Score(5.8, 7.666, -0);
        gymnast2.PommelHorseScore = new Score(6, 8.366, -0);
        gymnast2.RingsScore = new Score(5.8, 8.2, -0);
        gymnast2.VaultScore = new Score(5.6, 9.4, -0);
        gymnast2.ParallelBarsScore = new Score(6.1, 8.7, -0);
        gymnast2.HighBarScore = new Score(6, 8.5, -0);
        gymnast2.UpdateTotalScore();

        MaleCompetitor gymnast3 = new MaleCompetitor("RICHARD Frederick", 310, "USA");
        gymnast3.FloorScore = new Score(6, 8.633, -0);
        gymnast3.PommelHorseScore = new Score(5.7, 8.033, -0);
        gymnast3.RingsScore = new Score(5.2, 8.3, -0);
        gymnast3.VaultScore = new Score(5.2, 9.366, -0);
        gymnast3.ParallelBarsScore = new Score(6, 8.6, -0);
        gymnast3.HighBarScore = new Score(5.8, 7.5, -0);
        gymnast3.UpdateTotalScore();

        MaleCompetitor gymnast4 = new MaleCompetitor("SUN Wei", 145, "CHN");
        gymnast4.FloorScore = new Score(5.7, 7.933, -0.3);
        gymnast4.PommelHorseScore = new Score(6.2, 6.1, -0);
        gymnast4.RingsScore = new Score(5.9, 8.366, -0);
        gymnast4.VaultScore = new Score(5.6, 8.566, -0);
        gymnast4.ParallelBarsScore = new Score(6.1, 8.3, -0);
        gymnast4.HighBarScore = new Score(6.1, 8.133, -0);
        gymnast4.UpdateTotalScore();

        return RankMaleCompetitors([gymnast1, gymnast2, gymnast3, gymnast4]);
    }

    private ObservableCollection<MaleCompetitor> RankMaleCompetitors(ObservableCollection<MaleCompetitor> competitors)
    {
        MaleCompetitor temp;

        for (int i = 0; i < competitors.Count; i++)
        {
            for (int sort = 0; sort < competitors.Count - 1; sort++)
            {
                if (Convert.ToDouble(competitors[sort].TotalScore) < Convert.ToDouble(competitors[sort + 1].TotalScore))
                {
                    temp = competitors[sort + 1];
                    competitors[sort + 1] = competitors[sort];
                    competitors[sort] = temp;
                }
            }
            competitors[i].CurrentRank = i + 1;
        }

        return competitors;
    }
}
