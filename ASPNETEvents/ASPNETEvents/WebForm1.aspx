<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPNETEvents.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="MyButton" runat="server" OnClick="Button_Click" Text="MyButton" />
        <asp:Label ID="MyLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
