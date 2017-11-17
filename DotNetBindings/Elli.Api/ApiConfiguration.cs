using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elli.Api.Base
{
    //TODO:Correct Client, and make it to OAPI Client ID, Remove Elli From Class Name
    public class ApiConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("apiHost", DefaultValue = "http://api.elliemae.com", IsRequired = false)]
        public string ApiHost
        {
            get
            {
                return (string)this["apiHost"];
            }
            set
            {
                this["apihost"] = value;
            }
        }

        [ConfigurationProperty("apiClientId", IsRequired = true)]
        public string ApiClientId
        {
            get
            {
                return (string)this["apiClientId"];
            }
            set
            {
                this["apiClientId"] = value;
            }
        }

        [ConfigurationProperty("clientSecret", IsRequired = true)]
        public string ClientSecret
        {
            get
            {
                return (string)this["clientSecret"];
            }
            set
            {
                this["clientSecret"] = value;
            }
        }

        [ConfigurationProperty("idpHost", DefaultValue = "idp.elliemae.com", IsRequired = true)]
        public string IdpHost
        {
            get
            {
                return (string)this["idpHost"];
            }
            set
            {
                this["idpHost"] = value;
            }
        }

        [ConfigurationProperty("redirectUrl", IsRequired = true)]
        public string RedirectUrl
        {
            get
            {
                return (string)this["redirectUrl"];
            }
            set
            {
                this["redirectUrl"] = value;
            }
        }
    }
}
