<%@ Page Language="C#" AutoEventWireup="true" CodeFile="H9574_T2.aspx.cs" Inherits="H9574_T2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Kuvien esittäminen</h1>
        <asp:DropDownList ID="DDLpicture" runat="server" onselectedindexchanged="DDLpicture_SelectedIndexChanged"></asp:DropDownList>
        <asp:Image ID="Image" runat="server" />
        <asp:Label ID="myLabel" runat="server" />
    </div>
    </form>
</body>
</html>
