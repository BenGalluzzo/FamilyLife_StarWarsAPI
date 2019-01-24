using System;

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StarWars.Model
{
    [DataContract(Name = "vehicles")]
    public class Vehicle
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "model")]
        public string Model { get; set; }
        [DataMember(Name = "manufacturer")]
        public string Manufacturer { get; set; }
        [DataMember(Name = "cost_in_credits")]
        public string CreditCost { get; set; }
        [DataMember(Name = "length")]
        public string Length { get; set; }
        [DataMember(Name = "max_atmosphere_speed")]
        public string MaxAtmosphereSpeed { get; set; }
        [DataMember(Name = "crew")]
        public string CrewCount { get; set; }
        [DataMember(Name = "passengers")]
        public string PassengerCount { get; set; }
        [DataMember(Name = "cargo_capacity")]
        public string CargoCapacity { get; set; }
        [DataMember(Name = "consumables")]
        public string Consumables { get; set; }
        [DataMember(Name = "vehicle_class")]
        public string VehicleClass { get; set; }

        [IgnoreDataMember]
        [DataMember(Name = "pilots")]
        public List<string> Pilots { get; set; }
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
