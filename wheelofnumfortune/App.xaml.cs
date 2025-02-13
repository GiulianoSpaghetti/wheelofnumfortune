namespace wheelofnumfortune
{
    public partial class App : Application
    {
        public static readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
