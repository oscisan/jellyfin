#nullable disable
#pragma warning disable CS1591

using System;

namespace MediaBrowser.Model.Querying
{
    public class QueryFiltersLegacy
    {
        public QueryFiltersLegacy()
        {
            Genres = Array.Empty<string>();
            Tags = Array.Empty<string>();
            OfficialRatings = Array.Empty<string>();
            Years = Array.Empty<int>();
            ChannelGroups = Array.Empty<string>();
        }

        public string[] Genres { get; set; }

        public string[] Tags { get; set; }

        public string[] OfficialRatings { get; set; }

        public int[] Years { get; set; }

        public string[] ChannelGroups { get; set; }
    }
}
