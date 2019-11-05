using System;
using Elli.Api.OAuth.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elli.Api.Base.Tests
{
    [TestClass]
    public class ApiClientProviderTests
    {
        [TestMethod]
        public void GetApiClient()
        {
            var client = ApiClientProvider.GetApiClient<TokenApi>();
            Assert.IsInstanceOfType(client, typeof(TokenApi));
            Assert.IsNotNull(client);
        }


    }
}
