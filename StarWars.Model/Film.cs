using System;

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StarWars.Model
{
    [DataContract(Name = "films")]
    public class Film
    {
        [DataMemberAttribute(Name = "title")]
        public string Title { get; set; }
        [DataMemberAttribute(Name = "episode_id")]
        public string EpisodeID { get; set; }

        [DataMemberAttribute(Name = "opening_crawl")]
        public string OpeningCrawl { get; set; }
        [DataMemberAttribute(Name = "director")]
        public string Director { get; set; }
        [DataMemberAttribute(Name = "producer")]
        public string Producer { get; set; }
        [DataMemberAttribute(Name = "release_date")]
        public string ReleaseDate { get; set; }

        [DataMemberAttribute(Name = "characters")]
        public List<string> Characters { get; set; }
        [DataMemberAttribute(Name = "planets")]
        public List<string> Planets { get; set; }
        [DataMemberAttribute(Name = "starships")]
        public List<string> Starships { get; set; }
        [DataMemberAttribute(Name = "vehicles")]
        public List<string> Vehicles { get; set; }
        [DataMember(Name = "species")]
        public List<string> Species { get; set; }

        [DataMember(Name = "created")]
        public string Created { get; set; }
        [DataMember(Name = "edited")]
        public string Edited { get; set; }
        [DataMember(Name = "url")]
        public string URL { get; set; }

    }
}
