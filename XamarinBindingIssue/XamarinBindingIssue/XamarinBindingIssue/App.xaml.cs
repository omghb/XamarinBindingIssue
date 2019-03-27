using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinBindingIssue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var viewModel = new MainViewModel();
            MainPage = new MainPage { BindingContext = viewModel };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
