using FinalProject.Pages;

namespace FinalProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("LiveBroadcast", typeof(LiveBroadcast));
            Routing.RegisterRoute("LiveScores", typeof(LiveScores));
        }
    }
}
