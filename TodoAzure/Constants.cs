namespace TodoAzure
{
    public static class Constants
    {
        // Replace strings with your own values
        // Azure Active Directory B2C
        public static readonly string Tenant = "celock.onmicrosoft.com"; // Domain/resource name from AD B2C
        public static readonly string ClientID = "d87a7ce7-70c6-4b43-8dff-2209ec666bc7"; // Application ID from AD B2C
        public static readonly string PolicySignUpSignIn = "B2C_1_SignUpIn"; // Policy name from AD B2C
        public static readonly string[] Scopes = { "" }; // Leave blank unless additional scopes have been added to AD B2C
        public static string AuthorityBase = $"https://login.microsoftonline.com/tfp/{Tenant}/"; // Doesn't require editing
        public static string Authority = $"{AuthorityBase}{PolicySignUpSignIn}"; // Doesn't require editing
        public static readonly string URLScheme = "msald87a7ce7-70c6-4b43-8dff-2209ec666bc7"; // Custom Redirect URI from AD B2C (without ://auth/)
        public static readonly string RedirectUri = $"{URLScheme}://auth"; // Doesn't require editing

        // Azure Mobile App
        public static readonly string AzureMobileAppURL = @"https://celock.azurewebsites.net";
    }
}
