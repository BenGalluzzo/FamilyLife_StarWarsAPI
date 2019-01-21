using System;

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StarWars.Model
{
    [DataContract(Name = "people")]
    public class ModelItems<T> : ModelItem where T : ModelItem
    {
        [DataMember(Name = "count")]
        public int Count { get; set; }
        [DataMember(Name = "next")]
        public string NextPage { get; set; }
        [DataMember(Name = "previous")]
        public string PreviousPage { get; set; }
        [DataMember(Name = "results")]
        public List<T> Results { get; set; }


    }

}
