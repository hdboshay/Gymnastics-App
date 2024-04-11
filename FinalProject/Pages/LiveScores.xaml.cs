using FinalProject.Models.ViewModels;

namespace FinalProject.Pages;

public partial class LiveScores : ContentPage
{
	public LiveScores()
	{
		InitializeComponent();

        BindingContext = new LiveScoresViewModel();
    }
}