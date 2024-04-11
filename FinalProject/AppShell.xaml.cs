using FinalProject.Pages;

namespace FinalProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("RoutineReplay", typeof(RoutineReplay));
            Routing.RegisterRoute("LiveScores", typeof(LiveScores));
        }
    }
}
