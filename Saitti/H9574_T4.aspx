﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="H9574_T4.aspx.cs" Inherits="H9574_T4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RockoRecords</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>4a: RockoRecords</h1>
            <asp:Button ID="btnHaeKaikki" runat="server" Text="Hae koko levyvarasto" OnClick="btnHaeKaikki_Click"/>
            <asp:Button ID="btnHaeArtisti" runat="server" Text="Hae artistin mukaan" OnClick="btnHaeArtisti_Click"/>
            <asp:RadioButtonList runat="server">
                <asp:ListItem>Halvat (alle 10)</asp:ListItem>
                <asp:ListItem>Keskihintaiset (10-20)</asp:ListItem>
                <asp:ListItem>Kalliit (yli 20)</asp:ListItem>
            </asp:RadioButtonList>
            <asp:DropDownList ID="Countries" runat="server"></asp:DropDownList>
        <div id ="esitys">
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
        </div>
        <div id="footer">
            <asp:Label ID="lblMessage" runat="server" Text="..."></asp:Label>
        </div>

    </div>
    </form>
</body>
</html>
