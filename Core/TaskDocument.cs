using Newtonsoft.Json;

namespace LearnSmartCoding.CosmosDb.Linq.API.Core
{
   public class Attachment
   {
      [JsonProperty("id")]
      public string Id { get; set; } = string.Empty;

      [JsonProperty("fileName")]
      public string FileName { get; set; } = string.Empty;

      [JsonProperty("url")]
      public string Url { get; set; } = string.Empty;
   }

   public class Subtask
   {
      [JsonProperty("id")]
      public string Id { get; set; } = string.Empty;

      [JsonProperty("title")]
      public string Title { get; set; } = string.Empty;

      [JsonProperty("status")]
      public string Status { get; set; } = string.Empty;
   }
   public class TasksDocument
   {
      [JsonProperty("id")]
      public string Id { get; set; } = string.Empty;
      [JsonProperty("taskId")]
      public string TaskId { get; set; } = string.Empty;

      [JsonProperty("userId")]
      public string UserId { get; set; } = string.Empty;

      [JsonProperty("title")]
      public string Title { get; set; } = string.Empty;

      [JsonProperty("description")]
      public string Description { get; set; } = string.Empty;

      [JsonProperty("dueDate")]
      public DateTime DueDate { get; set; }

      [JsonProperty("status")]
      public string Status { get; set; } = string.Empty;

      [JsonProperty("priority")]
      public string Priority { get; set; } = string.Empty;

      [JsonProperty("labels")]
      public List<string> Labels { get; set; } = [];

      [JsonProperty("attachments")]
      public List<Attachment> Attachments { get; set; } = [];

      [JsonProperty("subtasks")]
      public List<Subtask> Subtasks { get; set; } = [];
   }
}
