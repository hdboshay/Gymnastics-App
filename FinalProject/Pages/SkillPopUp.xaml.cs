using CommunityToolkit.Maui.Views;
using FinalProject.Models.ViewModels;

namespace FinalProject.Pages;

public partial class SkillPopUp : Popup
{
	public SkillPopUp()
	{
		InitializeComponent();

        BindingContext = new SkillPopUpViewModel();
    }
}