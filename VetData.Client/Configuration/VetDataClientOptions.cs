namespace VetData.Client.Configuration;

public class VetDataClientOptions
{
    public const string SectionName = "VetDataClient";
    
    public string BaseUrl { get; set; } = "https://api.vetdata.net/";
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);
}