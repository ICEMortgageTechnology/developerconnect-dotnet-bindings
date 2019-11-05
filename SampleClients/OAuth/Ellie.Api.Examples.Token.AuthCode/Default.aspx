<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ellie.Api.Examples.Token.AuthCode.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Please make a selection:<br />
        <br />
        <asp:HyperLink ID="hlBorrower" runat="server" NavigateUrl="~/BorrowerLogin.aspx">Borrower Login</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="hlAdmin" runat="server">Admin Login</asp:HyperLink>
    
        <br />
        <br />
    
    </div>
        <asp:LinkButton ID="lnbLogout" runat="server" OnClick="lnbLogout_Click" Visible="False">Logout</asp:LinkButton>
        <br />
        <br />
        <br />
        Notes:<br />
        Authcode Flow Specifications:
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://tools.ietf.org/html/rfc6749#section-4.1" Target="_blank">RFC6749</asp:HyperLink>
        <br />
        This sample web application contains following examples:<br />
        <ol>
            <li>Admin/Lender Login using Auth Code Flow [On Default.aspx.cs]</li>
            <li>Borrower Login Using Auth Code Flow [On BorrowerLogin.aspx.cs]</li>
            <li>Exchange Auth Code for Access Token [On ResponseHandler.aspx.cs]</li>
            <li>Logout [On Default.aspx.cs]</li>
        </ol>
    </form>
</body>
</html>
