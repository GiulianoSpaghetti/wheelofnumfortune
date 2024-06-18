namespace wheelofnumfortune
{
    public partial class App : Application
    {
        public static readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
