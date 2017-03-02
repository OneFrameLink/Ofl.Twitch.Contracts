using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ofl.Twitch.V5
{
    public class Video
    {
        public string Title { get; set; }

        public string Description { get; set; }

        [JsonProperty("description_html")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("broadcast_id")]
        public long BroadcastId { get; set; }

        [JsonProperty("broadcast_type")]
        public string BroadcastType { get; set; }

        public string Status { get; set; }

        [JsonProperty("tag_list")]
        public string TagList { get; set; }

        public long Views { get; set; }

        public Uri Url { get; set; }

        public string Language { get; set; }

        public string Viewable { get; set; }

        [JsonProperty("viewable_at")]
        public DateTimeOffset? ViewableAt { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        public string Game { get; set; }

        public long Length { get; set; }

        public IReadOnlyDictionary<string, Uri> Preview { get; set; }

        public IReadOnlyDictionary<string, IReadOnlyCollection<Thumbnail>> Thumbnails { get; set; }

        public IReadOnlyDictionary<string, decimal> Fps { get; set; }

        public IReadOnlyDictionary<string, string> Resolutions { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("published_at")]
        public DateTimeOffset PublishedAt { get; set; }

        public Channel Channel { get; set; }

        // TODO: muted_segments
    }
}
