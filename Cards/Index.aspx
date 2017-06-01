<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Cards.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbDeckStatus" runat="server" Text=""></asp:Label>
    </div>
        <div>
            <asp:Button ID="btnShuffle" runat="server" Text="Shuffle Deck" OnClick="btnShuffle_Click" /><br />
            <asp:Button ID="btnOrder" runat="server" Text="Order Deck" OnClick="btnOrder_Click" />
        </div>
        <div>
            <p>Cards in Deck</p>
            <asp:Label ID="lbDeckCards" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
