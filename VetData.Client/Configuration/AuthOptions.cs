namespace VetData.Client.Configuration;

public class AuthOptions
{
    public const string SectionName = "VetDataAuth";
    public const string GrantType = "http://auth0.com/oauth/grant-type/password-realm";
    public const string ClientId = "p9vvyF08lLYNzAfcDiWuLJf4mWGdGm2M";
    public const string Audience = "https://vetdata.net";
    public const string Realm = "PartnersDB";
    public const string ProductCode = "Vetdata";
    public const string AuthEndpoint = "https://auth.covetrus.com/oauth/token";

    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}