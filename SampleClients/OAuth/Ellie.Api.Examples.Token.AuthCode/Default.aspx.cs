/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

using System;
using System.Configuration;
using System.Web;
using System.Web.UI;
using Elli.Api.Base;

namespace Ellie.Api.Examples.Token.AuthCode
{
    public partial class Index : Page
    {
        /// <summary>
        /// Example:generating Authcode flow login URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            var config = (ApiConfiguration)ConfigurationManager.GetSection("ElliApiConfig");

            //Setting up the redirect url for admin login
            var adminLoginUrl = $"https://{config.IdpHost}/authorize?client_id={config.ApiClientId}&response_type=code&redirect_uri={HttpUtility.UrlEncode(config.RedirectUrl)}&scope=lp";
            hlAdmin.NavigateUrl = adminLoginUrl;
            if (Session["access_token"] != null)
            {
                lnbLogout.Visible = true;
            }
            else
            {
                lnbLogout.Visible = false;
            }
        }


        /// <summary>
        /// Example:Logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lnbLogout_Click(object sender, EventArgs e)
        {
            if (Session["access_token"] == null) return;
            ((AccessToken)Session["access_token"]).Revoke();
            Session["access_token"] = null;
            Session.Abandon();
        }
    }
}