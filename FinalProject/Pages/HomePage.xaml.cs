using FinalProject.Models.ViewModels;

namespace FinalProject.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

        BindingContext = new HomePageViewModel();
    }
}