using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Utilities.Model
{
    public class Team : IComparable<Team>
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alternate_name")]
        public object AlternateName { get; set; }

        [JsonProperty("fifa_code")]
        public string FifaCode { get; set; }

        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        [JsonProperty("group_letter")]
        public string GroupLetter { get; set; }

        public override string ToString() => $"{Country} ({FifaCode})";

        public int CompareTo(Team other) => FifaCode.CompareTo(other.FifaCode);

        public override bool Equals(object obj)
        {
            if (obj is Team other)
            {
                return other.FifaCode == this.FifaCode;
            }

            return false;
        }

        public override int GetHashCode() => FifaCode.GetHashCode();
    }
}