using Newtonsoft.Json;

namespace LearnSmartCoding.CosmosDb.Linq.API.Core
{
    public class UserDocument
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;
        [JsonProperty("userId")]
        public string UserId { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("email")]
        public string Email { get; set; } = string.Empty;

        [JsonProperty("settings")]
        public UserSettings Settings { get; set; } = new();
    }

    public class UserSettings
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; } = string.Empty;

        [JsonProperty("notificationEnabled")]
        public bool NotificationEnabled { get; set; }
    }
}
