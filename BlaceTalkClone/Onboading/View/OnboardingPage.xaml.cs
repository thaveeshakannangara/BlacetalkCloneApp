using BlaceTalkClone.Home.View;
using BlaceTalkClone.Onboading.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlaceTalkClone.Onboading.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnboardingPage : ContentPage
    {

        List<OnboardingModel> OnboardingList = new List<OnboardingModel>();

        public OnboardingPage()
        {
            InitializeComponent();
            InitializeOnboardingList();
            OnboardingCarousel.ItemsSource = OnboardingList;
        }

        private void InitializeOnboardingList()
        {
            OnboardingList.Add(new OnboardingModel()
            {
                ImageSource = "onboarding_myapp.png",
                Title = "Sri Lankan Podcasting",
                Description = "A truly Si Lankan podcasting and knowledge-sharing platform that assists you to listen and enhance your knowledge in various subjects."
            });

            OnboardingList.Add(new OnboardingModel()
            {
                ImageSource = "onboarding_active.png",
                Title = "Discover,Listen & Learn",
                Description = "You can discover, listen to various types of precious content from serveral speakers and channels and learn from the native sinhalese speakers."
            });

            OnboardingList.Add(new OnboardingModel()
            {
                ImageSource = "onboarding_audio.png",
                Title = "Listen Everywhere",
                Description = "With the background play feature, now you can easily listen and learn while you're travelling or even when you are at work."
            });

            OnboardingList.Add(new OnboardingModel()
            {
                ImageSource = "onboarding_pushnotification.png",
                Title = "Stay Updated",
                Description = "Keep yourself updated with the upcoming Clubhouse rooms, events, newly recorded episodes, and updates."
            });

        }

        private void SkipButton_Clicked(object sender, EventArgs e)
        {
            if (OnboardingCarousel.ItemsSource != null)
            {
                if (OnboardingCarousel.Position == 3)
                {
                    Application.Current.MainPage = new NavigationPage(new BlaceHomePage())
                    {
                        BarBackgroundColor = Color.FromHex("ffffff")
                    };
                }
                else
                {
                    OnboardingCarousel.Position = OnboardingCarousel.Position + 1;
                }
            }
        }
    }
}