using System.Text.Json.Serialization;

namespace ascLibrary.src.common.models;

public class Email
{
    [JsonPropertyName("senderId")]
    public string SenderId { get; set; }

    [JsonPropertyName("toList")]
    public List<Receiver> ToList { get; set; } = [];

    [JsonPropertyName("ccList")]
    public List<Receiver> CcList { get; set; } = [];

    [JsonPropertyName("bccList")]
    public List<Receiver> BccList { get; set; } = [];

    [JsonPropertyName("mailSubject")]
    public string MailSubject { get; set; }

    [JsonPropertyName("mailBody")]
    public MailBody MailBody { get; set; }

    [JsonPropertyName("attachments")]
    public List<string> Attachments { get; set; } = [];

    [JsonPropertyName("visibility")]
    public Visibility? Visibility { get; set; }

    [JsonPropertyName("deliveryTime")]
    public DateTime? DeliveryTime { get; set; }

    [JsonPropertyName("mailProcessed")]
    public bool MailProcessed { get; set; } = false;
}


public enum Visibility
{
    BCC = 0,
    CC = 1
}

public class MailBody
{
    [JsonPropertyName("heading")]
    public string? Heading { get; set; }

    [JsonPropertyName("subHeading")]
    public string? SubHeading { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; }
}
