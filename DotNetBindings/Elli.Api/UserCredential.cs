using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Elli.Api.Base
{
    public class UserCredential
    {
        public string UserName { get; set; }

        SecureString password;

        public String Password
        {
            get { return SecureStringToString(password); }
            set
            {
                if (value != null)
                {
                    password = new SecureString();
                    foreach (char c in value) password.AppendChar(c);
                }
            }
        }

        String SecureStringToString(SecureString value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

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
