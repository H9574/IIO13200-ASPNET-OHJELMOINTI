<%@ Page Language="C#" AutoEventWireup="true" CodeFile="H9574_Index.aspx.cs" Inherits="H9574_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sanna Räisänen, H9574</title>
    <link href="CSS/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="Images/Sanna.jpg" alt="Sannan kuva" runat="server"/>
        <h1>Sanna Räisänen, H9574</h1>
        <h2>Tekemäni tehtävät</h2>
        <asp:Table runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell>Tehtävä</asp:TableCell>
                <asp:TableCell>H9574_Index</asp:TableCell>
                <asp:TableCell><a href="H9574_T2.aspx">Tehtävä 2</a></asp:TableCell>
                <asp:TableCell><a href="H9574_T3.aspx">Tehtävä 3</a></asp:TableCell> 
                <asp:TableCell><a href="H9574_T4.aspx">Tehtävä 4</a></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell>Pistemäärä</asp:TableCell>
                <asp:TableCell>5/5</asp:TableCell>
                <asp:TableCell>/10</asp:TableCell>
                <asp:TableCell>/10</asp:TableCell> 
                <asp:TableCell>/10</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <h2>Palaute kokeesta</h2>
        <p>Koe oli hyvä ja tehtävät selkeitä, mutta liian pitkä.</p>
    </div>
    </form>
</body>
</html>
