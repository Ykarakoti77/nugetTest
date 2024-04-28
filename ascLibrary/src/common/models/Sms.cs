using System.Text.Json.Serialization;

namespace ascLibrary.src.common.models;

public class Sms
{
    [JsonPropertyName("sender")]
    public string? Sender { get; set; }

    [JsonPropertyName("receivers")]
    public List<PhoneDetails> Receivers { get; set; } = [];

    [JsonPropertyName("textBody")]
    public string TextBody { get; set; } = "";

    [JsonPropertyName("link")]
    public List<string>? Link { get; set; } // This could be a CTA to the user and it is meant to be clicked.
}

public class PhoneDetails
{ 
    public static Dictionary<string, string> CountryCode { get; set; } = new() { { "INDIA", "+91" } };
    public string PhoneNumber { get; set; } = "";
}

public class Receiver
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; } = "";
}