<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebServiceTerceroOnline.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TxtBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Suma" OnClick="Button1_Click"  />
            <asp:Button ID="Button2" runat="server" Text="Resta" OnClick="Button2_Click"  />
            <asp:Button ID="Button3" runat="server" Text="Multiplicación" OnClick="Button3_Click"  />
            <asp:Button ID="Button4" runat="server" Text="División" OnClick="Button4_Click"  />
            <asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label>
        </div>
    </form>
</body>
</html>
