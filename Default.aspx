<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="B2._Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Bank System</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>Bank Account System</h2>

    Account Number:
    <asp:TextBox ID="txtAccountNumber" runat="server"></asp:TextBox>

    <br /><br />

    Amount:
    <asp:TextBox ID="txtAmount"
        runat="server"
        TextMode="Number">
    </asp:TextBox>

    <br /><br />

    <asp:Button ID="btnDeposit"
        runat="server"
        Text="Deposit"
        OnClick="btnDeposit_Click" />

    <asp:Button ID="btnWithdraw"
        runat="server"
        Text="Withdraw"
        OnClick="btnWithdraw_Click" />

    <br /><br />

    Current Balance:
    <asp:Label ID="lblBalance"
        runat="server">
    </asp:Label>

    <br /><br />

    Status:
    <asp:Label ID="lblStatus"
        runat="server">
    </asp:Label>

</form>
</body>
</html>
