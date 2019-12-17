using System;
using System.Configuration;
using System.Reflection;

namespace Elli.Api.Base
{
    public static class ApiClientProvider
    {
        private static ApiConfiguration Config;
        static ApiClientProvider()
        {
        }

        public static T GetApiClient<T>(ApiConfiguration config)
        {
            Config = config;

            if (Config != null)
            {
                string apiBasePath = Config != null && string.IsNullOrEmpty(Config.ApiHost) ? "https://api.elliemae.com" : Config.ApiHost;
                object[] parameters = { apiBasePath };
                T retVal = (T)Activator.CreateInstance(typeof(T), parameters);
                return retVal;
            }
            throw new ConfigurationErrorsException();
        }

        public static T GetApiClient<T>(AccessToken token, ApiConfiguration config)
        {
            var retVal = GetApiClient<T>(config);
            var configProperty = retVal.GetType().GetProperty("Configuration");
            var configInstance = configProperty?.GetValue(retVal);
            var tokenProperty = configInstance?.GetType().GetProperty("AccessToken");
            tokenProperty?.SetValue(configInstance, token.Token);
            return retVal;
        }
    }
}
