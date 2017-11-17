using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elli.Api.Base
{
    public class UserCredential
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string SiteId { get; set; }

        public string InstanceId { get; set; }

        public IdentityType IdentityType { get; set; }

        public string UserNameRealm
        {
            get
            {
                switch (IdentityType)
                {
                    case IdentityType.Borrower:
                        return $"{UserName}@site:{SiteId}";
                    case IdentityType.Lender:
                        return $"{UserName}@encompass:{InstanceId}";
                    default:
                        return UserName;
                }
            }
        }
    }

    public enum IdentityType
    {
        Lender,
        Borrower
    }
}
