using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HueApi.Models
{
  public class BehaviorScript : HueResource
  {
    [JsonPropertyName("description")]
    public string Description { get; set; } = default!;

    [JsonPropertyName("configuration_schema")]
    public string ConfigurationSchema { get; set; } = default!;

    [JsonPropertyName("trigger_schema")]
    public string TriggerSchema { get; set; } = default!;

    [JsonPropertyName("state_schema")]
    public string StateSchema { get; set; } = default!;

    [JsonPropertyName("version")]
    public string Version { get; set; } = default!;

    [JsonPropertyName("supported_features")]
    public List<string>? SupportedFeatures { get; set; }

    [JsonPropertyName("max_number_instances")]
    public int MaxNumberInstances { get; set; }

  }
}
