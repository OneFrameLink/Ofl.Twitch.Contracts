using Newtonsoft.Json;

namespace Ofl.Twitch.V5
{
    public class Channel
    {
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }
}
