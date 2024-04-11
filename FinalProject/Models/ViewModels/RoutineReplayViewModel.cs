using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FinalProject.Models.CompetitorModels;
using FinalProject.Models.DetailModels;
using FinalProject.Models.RoutineModels;
using System.Diagnostics;

namespace FinalProject.Models.ViewModels;

internal partial class RoutineReplayViewModel : ObservableObject
{
    private IPopupService _popupService;
    //constructor
    public RoutineReplayViewModel()
    {
        Competitor = new FemaleCompetitor("PATTERSON Carly", 416, "USA");
        CurrentRoutine = new Routine("Womens", "Beam");
        GenRoutine();
        CurrentRoutine.CalculateDScore();
        CurrentRoutine.OrderSkillsByPos();
    }

    [ObservableProperty]
    private string posInRoutine;

    [ObservableProperty]
    private string name;

    [ObservableProperty]
    public string letterRating;

    [ObservableProperty]
    public double value;

    [ObservableProperty]
    public string description;

    [ObservableProperty]
    public double dScore;

    [ObservableProperty]
    public Routine currentRoutine;

    [ObservableProperty]
    public FemaleCompetitor competitor;

    [RelayCommand]
    void Click()
    {
        Debug.WriteLine("cjeese");
        //await _popupService.ShowPopupAsync<SkillPopUpViewModel>();
    }

    private void GenRoutine()
    {
        //example beam routine from 2004 olympics
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "Split sit", "A", 0.1, "Mount"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "Standing split scale", "A", 0.1, "No Desc"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "Standing Arabian salto", "F", 0.6, "No Desc"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "Front aerial", "D", 0.4, "Acrobatic Series"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "flic flac", "B", 0.2, "Acrobatic Series"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "back layout, step-out", "C", 0.3, "Acrobatic Series (+0.2 Connection value of series)"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "Front salto", "D", 0.4, "No Desc"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "sheep jump", "D", 0.4, "No Desc (+0.1 Connection value combined with previous move)"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "Half turn", "N/A", 0, "No Desc"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "Full turn", "A", 0.1, "No Desc"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "Switch leap", "C", 0.3, "No Desc"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "back tuck", "C", 0.3, "No Desc (+0.1 Connection value combined with previous move)"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "Round-off", "B", 0.2, "No Desc"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "flic flac two feet", "B", 0.2, "No Desc"));
        CurrentRoutine.Skills.Add(new Skill(currentRoutine.Skills.Count + 1, "double Arabian salto", "G", 0.7, "Dismount"));
    }
}
