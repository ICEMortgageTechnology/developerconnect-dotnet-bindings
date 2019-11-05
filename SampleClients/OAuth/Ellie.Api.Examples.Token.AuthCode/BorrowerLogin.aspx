<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowerLogin.aspx.cs" Inherits="Ellie.Api.Examples.Token.AuthCode.BorrowerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtSiteId">Please enter Site Id:</label>
            <asp:TextBox runat="server" ID="txtSiteId" placeholder="Site Id"></asp:TextBox>
            <asp:Button runat="server" id="btnSubmit" OnClick="btnSubmit_OnClick" Text="Submit"/>
        </div>
    </form>
</body>
</html>
