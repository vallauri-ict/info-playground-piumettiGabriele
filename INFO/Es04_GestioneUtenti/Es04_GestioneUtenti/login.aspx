<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Es04_GestioneUtenti.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPwd" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
            <br />
            <asp:Button Text="Login" ID="btnLogin" OnClick="btnLogin_Click" runat="server"/>
            <asp:Button Text="Registrati" ID="btnRegistrati" OnClick="btnRegistrati_Click" runat="server"/>
            <br />
            <br />
            <asp:Label ID="lblMessaggio" runat="server" Text="___"></asp:Label>
        </div>
    </form>
</body>
</html>
