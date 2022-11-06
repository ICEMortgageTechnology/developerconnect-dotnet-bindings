using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Elli.Api.OAuth.Api;

namespace Elli.Api.Base
{
    public class AccessToken
    {
        private static ApiConfiguration Config;
        private const string PasswordGrantType = "password";
        private const string AuthCodeGrantType = "authorization_code";
        private const string Scope = "lp";

        public string ApiClientId { get; private set; }

        public string ClientSecret { get; private set; }

        public string RedirectUrl { get; private set; }

        public string Token { get; private set; }

        public string BearerToken => $"Bearer {Token}";

        static AccessToken()
        {
        }

        private AccessToken()
        {
            //Private constructor for preventing initialization of AccessToken object without appropriate credentials.
        }

        public static AccessToken GetAccessToken(UserCredential credentials, string apiClientId = null, string clientSecret = null, ApiConfiguration config = null)
        {
            Config = config;

            var accessToken = new AccessToken();
            if (credentials == null)
                throw new ArgumentNullException();
            //EST-2795 Allowing Username, password and instance id to read through config if not passed by caller
            credentials.UserName = credentials.UserName ?? Config.Username;
            credentials.Password = credentials.Password ?? Config.Password;
            credentials.InstanceId = credentials.InstanceId ?? Config.InstanceId;

            accessToken.ApiClientId = apiClientId ?? Config.ApiClientId;
            accessToken.ClientSecret = clientSecret ?? Config.ClientSecret;
            var tokenClient = ApiClientProvider.GetApiClient<TokenApi>(Config);
            tokenClient.Configuration.Username = accessToken.ApiClientId;
            tokenClient.Configuration.Password = accessToken.ClientSecret;
            var resp = tokenClient.GenerateToken(PasswordGrantType, credentials.UserNameRealm, credentials.Password, Scope);
            accessToken.Token = resp?.AccessToken;
            return accessToken;
        }

        public static AccessToken GetAccessToken(string authCode, string redirectUrl = null, string apiClientId = null, string clientSecret = null, ApiConfiguration config = null)
        {
            Config = config;

            var accessToken = new AccessToken();
            accessToken.ApiClientId = apiClientId ?? Config.ApiClientId;
            accessToken.ClientSecret = clientSecret ?? Config.ClientSecret;
            accessToken.RedirectUrl = redirectUrl ?? Config.RedirectUrl;
            var tokenClient = ApiClientProvider.GetApiClient<TokenApi>(Config);
            tokenClient.Configuration.Username = accessToken.ApiClientId;
            tokenClient.Configuration.Password = accessToken.ClientSecret;
            var resp = tokenClient.GenerateToken(AuthCodeGrantType, null, null, null, accessToken.RedirectUrl, authCode);
            accessToken.Token = resp?.AccessToken;
            return accessToken;
        }

        public void Revoke()
        {
            var revocationApiClient = ApiClientProvider.GetApiClient<RevocationApi>(Config);
            revocationApiClient.Configuration.Username = Config.ApiClientId;
            revocationApiClient.Configuration.Password = Config.ClientSecret;
            revocationApiClient.RevokeToken(Token);
        }

        public override string ToString()
        {
            return Token;
        }
    }
}
