using FinalProject.Models.ViewModels;

namespace FinalProject.Pages;

public partial class LiveBroadcast : ContentPage
{
	public LiveBroadcast()
	{
		InitializeComponent();

        BindingContext = new LiveBroadcastViewModel();
    }
}