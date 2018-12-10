using System;
using Maps.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Maps.Views
{

    public partial class MapsPage : ContentPage
    {
        public MapsPageViewModel VM { get; set; }
        public Map MyMap;
        public MapsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            VM = new MapsPageViewModel();
            BindingContext = VM;

            InitializeComponent();


            MyMap = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(latitude: 27.9453715, longitude: -82.4659336), Distance.FromMiles(10)))
            {
                IsShowingUser = true,
                HeightRequest = Constants.Resources.ScreenHeight,
                WidthRequest = Constants.Resources.ScreenWidth,
                MapType = MapType.Hybrid
            };
            mapLayout.Children.Add(MyMap);
            VM.MapPins.ForEach(pin => MyMap.Pins.Add(pin));
        }


        void Back_Clicked(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
