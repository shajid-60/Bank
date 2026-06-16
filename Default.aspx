<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="A2_B1._Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Grade Management System</title>
</head>
<body>

<form id="form1" runat="server">

    <h2>Grade Management System</h2>

    Student ID:
    <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>

    <br /><br />

    Number:
    <asp:TextBox ID="txtNumber"
        runat="server"
        TextMode="Number">
    </asp:TextBox>

    <br /><br />

    <asp:Button ID="btnSubmit"
        runat="server"
        Text="Submit"
        OnClick="btnSubmit_Click" />

    <br /><br />

    Grade:
    <asp:Label ID="lblGrade"
        runat="server">
    </asp:Label>

    <br /><br />

    <h3>Total Students By Grade</h3>

    A+ :
    <asp:Label ID="lblAPlus" runat="server"></asp:Label>

    <br />

    B+ :
    <asp:Label ID="lblBPlus" runat="server"></asp:Label>

    <br />

    C+ :
    <asp:Label ID="lblCPlus" runat="server"></asp:Label>

    <br />

    F :
    <asp:Label ID="lblF" runat="server"></asp:Label>

</form>

</body>
</html>