using System;
using Maps.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Maps
{
    public partial class App : Application
    {
        static public int ScreenWidth;
        static public int ScreenHeight;
        public static double DisplayScreenWidth = 0f;
        public static double DisplayScreenHeight = 0f;
        public static double DisplayScaleFactor = 0f;
        public App()
        {
            InitializeComponent();
            InitStaticResources();
            MainPage = new MapsPage();
        }

        public void InitStaticResources()
        {
            try
            {
                string ScreenDetails = Device.RuntimePlatform + " Device Screen Size:\n" +
                    $"Width: {DisplayScreenWidth}\n" +
                    $"Height: {DisplayScreenHeight}\n" +
                    $"Scale Factor: {DisplayScaleFactor}";
                Constants.Resources.Init();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
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
