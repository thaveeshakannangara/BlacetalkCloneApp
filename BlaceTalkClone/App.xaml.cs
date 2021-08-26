using BlaceTalkClone.Home.View;
using BlaceTalkClone.Onboading.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlaceTalkClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new OnboardingPage())
            {
                BarBackgroundColor = Color.FromHex("ffffff")
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
