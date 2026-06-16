<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="A2_B1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your application description page.</h3>
        <p>Use this area to provide additional information.</p>
    </main>
</asp:Content>

#CREATE DATABASE BankDB;
GO

USE BankDB;
GO

CREATE TABLE Accounts
(
    AccountNumber VARCHAR(20) PRIMARY KEY,
    Balance DECIMAL(10,2)
);
#
