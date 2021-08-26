using BlaceTalkClone.Home.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlaceTalkClone.Home.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlaceHomePage : ContentPage
    {

        List<EpisodesModel> EpisodeList = new List<EpisodesModel>();
        List<ChannelsModel> ChannelsList = new List<ChannelsModel>();
        List<SpeakersModel> SpeakersList = new List<SpeakersModel>();

        public BlaceHomePage()
        {
            InitializeComponent();
            InitializeEpisodesList();
            InitializeChannelsList();
            InitializeSpeakersList();

            EpisodesCollection.ItemsSource = EpisodeList;
            ChannelsCollection.ItemsSource = ChannelsList;
            SpeakersCollection.ItemsSource = SpeakersList;
        }


        private void InitializeEpisodesList()
        {
            EpisodeList.Add(new EpisodesModel()
            { 
                EpisodeNo = "E06",
                Title = "Mobile Development - Common Mistakes to Avoid when Developing Mobile Apps",
                ChannelName = "MOBILE APP TALKS",
                Date = "AUGUST 07"
            });

            EpisodeList.Add(new EpisodesModel()
            {
                EpisodeNo = "E01",
                Title = "Prepare for Interviews -  Tips of Job Interviews",
                ChannelName = "SL 6AM SUCCESS",
                Date = "AUGUST 05"
            });


            EpisodeList.Add(new EpisodesModel()
            {
                EpisodeNo = "E01",
                Title = "Presentations හොදටම කරමු - Presentations හොදටම කරමු Episode 01",
                ChannelName = "LETS TALK IN SINHALA",
                Date = "AUGUST 05"
            });

            EpisodeList.Add(new EpisodesModel()
            {
                EpisodeNo = "E01",
                Title = "Let's Learn SEO - What is SEO",
                ChannelName = "INSFRA RADIO",
                Date = "AUGUST 05"
            });
        }

        private void InitializeChannelsList()
        {
            ChannelsList.Add(new ChannelsModel()
            {
                ChannelImage = "channel_icon_Mayanna.png",
                ChannelName = "Mayanna",
                EpisodesCount = "13"
            });

            ChannelsList.Add(new ChannelsModel()
            {
                ChannelImage = "channel_icon_mobileapptalks.png",
                ChannelName = "Mobile APP Talks",
                EpisodesCount = "6"
            });

            ChannelsList.Add(new ChannelsModel()
            {
                ChannelImage = "channel_icon_OECSL.png",
                ChannelName = "OECSL",
                EpisodesCount = "5"
            });
        }

        private void InitializeSpeakersList()
        {
            SpeakersList.Add(new SpeakersModel()
            {
                SpeakerImage = "speakers_madusanka.png",
                SpeakerName = "Madusanka Premaratne",
                EpisodesCount = "20"
            });

            SpeakersList.Add(new SpeakersModel()
            {
                SpeakerImage = "speakers_charith.png",
                SpeakerName = "Charith Weerasooriya",
                EpisodesCount = "16"
            });

            SpeakersList.Add(new SpeakersModel()
            {
                SpeakerImage = "speakers_em_shaveen.png",
                SpeakerName = "Em Shaveen",
                EpisodesCount = "13"
            });
        }
 
    }
}