<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResponseHandler.aspx.cs" Inherits="Ellie.Api.Examples.Token.AuthCode.ResponseHandler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Your Access Token is: <asp:Label runat="server" id="lblAccessToken"></asp:Label>

        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/">Back to Home</asp:HyperLink>

    </div>
    </form>
</body>
</html>
