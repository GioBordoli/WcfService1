<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consume WCF Service</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Celsius to Fahrenheit</h3>
            <asp:TextBox ID="txtCelsius" runat="server"></asp:TextBox>
            <asp:Button ID="btnCtoF" runat="server" Text="Convert to °F" OnClick="btnCtoF_Click" />
            <asp:Label ID="lblFahrenheit" runat="server" />
        </div>
        <br />
        <div>
            <h3>Fahrenheit to Celsius</h3>
            <asp:TextBox ID="txtFahrenheit" runat="server"></asp:TextBox>
            <asp:Button ID="btnFtoC" runat="server" Text="Convert to °C" OnClick="btnFtoC_Click" />
            <asp:Label ID="lblCelsius" runat="server" />
        </div>
        <br />
        <div>
            <h3>Sort Comma-Separated Numbers</h3>
            <asp:TextBox ID="txtNumbers" runat="server"></asp:TextBox>
            <asp:Button ID="btnSort" runat="server" Text="Sort" OnClick="btnSort_Click" />
            <asp:Label ID="lblSortedNumbers" runat="server" />
        </div>
    </form>
</body>
</html>
