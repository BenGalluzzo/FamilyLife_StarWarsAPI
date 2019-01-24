using System;

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StarWars.Model
{
    [DataContract(Name = "species")]
    public class Species
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "classification")]
        public string Classification { get; set; }
        [DataMember(Name = "designation")]
        public string Designation { get; set; }
        [DataMember(Name = "average_height")]
        public string AverageHeight { get; set; }
        [DataMember(Name = "skin_colors")]
        public string SkinColors { get; set; }                  //comma delimited
        [DataMember(Name = "hair_colors")]
        public string HairColors { get; set; }                  //comma delimited
        [DataMember(Name = "eye_colors")]
        public string EyeColors { get; set; }                   //comma delimited
        [DataMember(Name = "average_lifespan")]
        public string AverageLifespan { get; set; }
        [DataMember(Name = "homeworld")]
        public string Homeworld { get; set; }
        [DataMember(Name = "language")]
        public string Language { get; set; }

        [IgnoreDataMember]
        [DataMember(Name = "people")]
        public List<string> People { get; set; }
        [IgnoreDataMember]
        [DataMember(Name = "films")]
        public List<string> Films { get; set; }

        [DataMember(Name = "created")]
        public string Created { get; set; }
        [DataMember(Name = "edited")]
        public string Edited { get; set; }
        [DataMember(Name = "url")]
        public string URL { get; set; }

    }
}
