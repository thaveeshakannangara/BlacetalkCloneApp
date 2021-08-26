using System;
using System.Collections.Generic;
using System.Text;

namespace BlaceTalkClone.Home.Model
{
    public class SpeakersModel
    {
        private string episodesCount = string.Empty;
        public string SpeakerImage { get; set; }
        public string SpeakerName { get; set; }

        public string EpisodesCount
        {
            get => episodesCount;
            set
            {
                episodesCount = value;

                if (!string.IsNullOrEmpty(value) && Convert.ToInt32(value) > 1)
                {
                    EpisodeString = "EPISODES";
                }
                else
                {
                    EpisodeString = "EPISODE";
                }
            }
        }
        public string EpisodeString { get; set; }
    }
}
