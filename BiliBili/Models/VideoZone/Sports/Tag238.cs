using System.Text.Json.Serialization;

namespace CustomToolbox.Bilibili.Models.VideoZone.Sports;

/// <summary>
/// 運動 -> 綜合運動 (comprehensive)
/// </summary>
public class Tag238
{
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}