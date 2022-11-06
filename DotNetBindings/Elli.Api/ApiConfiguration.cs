using System.Configuration;

namespace Elli.Api.Base
{
   //TODO:Correct Client, and make it to OAPI Client ID, Remove Elli From Class Name
   public class ApiConfiguration : ConfigurationSection
   {
      private string _apiHost;
      [ConfigurationProperty("apiHost", DefaultValue = "http://api.elliemae.com", IsRequired = false)]
      public string ApiHost
      {
         get
         {
            try
            {
               return _apiHost ?? (_apiHost = (string) this["apiHost"]);
            }
            catch
            {
               // ignored
            }

            return _apiHost;
         }
         set => _apiHost = value;
      }

      private string _apiClientId;
      [ConfigurationProperty("apiClientId", IsRequired = true)]
      public string ApiClientId
      {
         get
         {
            try
            {
               return _apiClientId ?? (_apiClientId = (string) this["apiClientId"]);
            }
            catch
            {
               // ignored
            }

            return _apiClientId;
         }
         set => _apiClientId = value;
      }

      private string _clientSecret;
      [ConfigurationProperty("clientSecret", IsRequired = true)]
      public string ClientSecret
      {
         get
         {
            try
            {
               return _clientSecret ?? (_clientSecret = (string) this["clientSecret"]);
            }
            catch
            {
               // ignored
            }

            return _clientSecret;
         }
         set => _clientSecret = value;
      }

      private string _idpHost;
      [ConfigurationProperty("idpHost", DefaultValue = "idp.elliemae.com", IsRequired = true)]
      public string IdpHost
      {
         get
         {
            try
            {
               return _idpHost ?? (_idpHost = (string) this["idpHost"]);
            }
            catch
            {
               // ignored
            }

            return _idpHost;
         }
         set => _idpHost = value;
      }

      private string _redirectUrl;
      [ConfigurationProperty("redirectUrl", IsRequired = true)]
      public string RedirectUrl
      {
         get
         {
            try
            {
               return _redirectUrl ?? (_redirectUrl = (string) this["redirectUrl"]);
            }
            catch
            {
               // ignored
            }

            return _redirectUrl;
         }
         set => _redirectUrl = value;
      }

      private string _username;
      [ConfigurationProperty("userName")]
      public string Username
      {
         get
         {
            try
            {
               return _username ?? (_username = (string) this["userName"]);
            }
            catch
            {
               // ignored
            }

            return _username;
         }
         set => _username = value;
      }

      private string _password;
      [ConfigurationProperty("password")]
      public string Password
      {
         get
         {
            try
            {
               return _password ?? (_password = (string) this["password"]);
            }
            catch
            {
               // ignored
            }

            return _password;
         }
         set => _password = value;
      }

      private string _instanceId;
      [ConfigurationProperty("instanceId")]
      public string InstanceId
      {
         get
         {
            try
            {
               return _instanceId ?? (_instanceId = (string) this["instanceId"]);
            }
            catch
            {
               // ignored
            }

            return _instanceId;
         }
         set => _instanceId = value;
      }
   }
}
