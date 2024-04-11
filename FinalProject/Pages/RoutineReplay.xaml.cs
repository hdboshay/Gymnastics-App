using FinalProject.Models.ViewModels;

namespace FinalProject.Pages;

public partial class RoutineReplay : ContentPage
{
    public RoutineReplay()
    {
        InitializeComponent();

        BindingContext = new RoutineReplayViewModel();
    }
}