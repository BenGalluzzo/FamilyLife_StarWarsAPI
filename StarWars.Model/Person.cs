using System;

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StarWars.Model
{
    [DataContract(Name = "results")]
    public class Person : ModelItem
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "height")]
        public string Height { get; set; }
        [DataMember(Name = "mass")]
        public string Mass { get; set; }
        [DataMember(Name = "hair_color")]
        public string HairColor { get; set; }
        [DataMember(Name = "skin_color")]
        public string SkinColor { get; set; }
        [DataMember(Name = "eye_color")]
        public string EyeColor { get; set; }
        [DataMember(Name = "birth_year")]
        public string BirthYear { get; set; }
        [DataMember(Name = "gender")]
        public string Gender { get; set; }
        [DataMember(Name = "homeworld")]
        public string Homeworld { get; set; }

        [IgnoreDataMember]
        [DataMember(Name = "films")]
        public List<string> Films { get; set; }
        [IgnoreDataMember]
        [DataMember(Name = "species")]
        public List<string> Species { get; set; }
        [IgnoreDataMember]
        [DataMember(Name = "vehicles")]
        public List<string> Vehicles { get; set; }
        [IgnoreDataMember]
        [DataMember(Name = "starships")]
        public List<string> Starships { get; set; }

        [DataMember(Name = "created")]
        public string Created { get; set; }
        [DataMember(Name = "edited")]
        public string Edited { get; set; }
        [DataMember(Name = "url")]
        public string URL { get; set; }

    }

}