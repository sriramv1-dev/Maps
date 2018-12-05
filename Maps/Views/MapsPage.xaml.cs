using System;
using Maps.ViewModels;
using Xamarin.Forms;

namespace Maps.Views
{
    public partial class MapsPage : ContentPage
    {
        public MapsPageViewModel VM { get; set; }
        public MapsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            VM = new MapsPageViewModel();
            BindingContext = VM;
            InitializeComponent();
        }

        void Back_Clicked(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
