
using System.Text.Json;
using ascLibrary.src.common.models;

class Program
{
    static void Main(string[] args)
    {
        var smsJson = File.ReadAllText("ShowCase/data/smsData.json");
        var emailJson = File.ReadAllText("ShowCase/data/emailData.json");

        var sms = JsonSerializer.Deserialize<Sms>(smsJson);
        var email = JsonSerializer.Deserialize<Email>(emailJson);

        Console.WriteLine(JsonSerializer.Serialize(sms));
        Console.WriteLine(JsonSerializer.Serialize(email));


    }
}
