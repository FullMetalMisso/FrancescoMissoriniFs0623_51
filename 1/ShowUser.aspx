<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowUser.aspx.cs" Inherits="ProgettoPomeridiano.ShowUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>Nome</h4>
           <asp:Label ID="TxtName" runat="server" Text=""></asp:Label> 
            <h4>Cognome</h4>
           <asp:Label ID="TxtSurname" runat="server" Text=""></asp:Label>
            
            <asp:Button ID="BtnShow" runat="server" Text="ShowUser" OnClick="BtnShow_Click" />
            <asp:Button ID="BtnReset" runat="server" OnClick="BtnReset_Click" Text="Reset" />
        </div>
    </form>
</body>
</html>
