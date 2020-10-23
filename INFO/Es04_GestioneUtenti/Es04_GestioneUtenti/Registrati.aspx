<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrati.aspx.cs" Inherits="Es04_GestioneUtenti.Registrati" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCognome" runat="server" Text="Cognome"></asp:Label>
            <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPwd" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDataNascita" runat="server" Text="Data di nascita"></asp:Label>
            <asp:TextBox ID="txtDataNascita" runat="server"></asp:TextBox>
            <!--<asp:calendar ID="d" runat="server"></asp:calendar>-->
            <br />
            <br />
            <br />
            <p>
                <asp:Label ID="lblMessaggio" runat="server" Text="___"></asp:Label>
            </p>

            <asp:Label ID="lblRegioni" runat="server" Text="Regione"></asp:Label>
            <asp:DropDownList ID="cmbRegione" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="lblProvincia" runat="server" Text="Provincia"></asp:Label>
            <asp:DropDownList ID="cmbProvincia" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="lblComune" runat="server" Text="Comune"></asp:Label>
            <asp:DropDownList ID="cmbComune" runat="server"></asp:DropDownList>

        </div>
        
        <p>
            <asp:Button Text="Registrati" ID="btnRegistrati" OnClick="btnRegistrati_Click" runat="server"/>
            </p>
        
    </form>
</body>
</html>
