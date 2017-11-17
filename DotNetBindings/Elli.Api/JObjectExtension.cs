using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Elli.Api.Base
{
    public static class JObjectExtension
    {
        static JObjectExtension()
        {
        }

        public static Dictionary<string, T> ToDictionary<T>(this JObject input)
        {
            return input.ToObject<Dictionary<string, T>>();
        }
    }
}
