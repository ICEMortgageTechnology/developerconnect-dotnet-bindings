using System;
using System.Configuration;
using System.Reflection;

namespace Elli.Api.Base
{
    public static class ApiClientProvider
    {
        private static readonly ApiConfiguration Config;
        static ApiClientProvider()
        {
            Config = (ApiConfiguration)ConfigurationManager.GetSection("ElliApiConfig");
        }

        public static T GetApiClient<T>()
        {
            if (Config != null)
            {
                var apiBasePath = Config != null && string.IsNullOrEmpty(Config.ApiHost) ? "https://api.elliemae.com" : Config.ApiHost;
                object[] parameters = { apiBasePath };
                var retVal = (T)Activator.CreateInstance(typeof(T), parameters);
                return retVal;
            }
            throw new ConfigurationErrorsException();
        }

        public static T GetApiClient<T>(AccessToken token)
        {
            var retVal = GetApiClient<T>();
            var configProperty = retVal.GetType().GetProperty("Configuration");
            var configInstance = configProperty?.GetValue(retVal);
            var tokenProperty = configInstance?.GetType().GetProperty("AccessToken");
            tokenProperty?.SetValue(configInstance, token.Token);
            return retVal;
        }
    }
}
