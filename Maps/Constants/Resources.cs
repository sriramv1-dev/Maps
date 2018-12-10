using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using FFImageLoading;
using FFImageLoading.Transformations;
using Xamarin.Forms;
namespace Maps.Constants
{
    public class Resources
    {
        public static double ScreenWidth, ScreenHeight;
        public static void Init()
        {
            ScreenWidth = 1 * App.ScreenWidth;
            ScreenHeight = 1 * App.ScreenHeight;

            Application.Current.Resources = new ResourceDictionary();
            Application.Current.Resources["ScreenWidth"] = ScreenWidth;
            Application.Current.Resources["ScreenHeight"] = ScreenHeight;
        }


    }
}
