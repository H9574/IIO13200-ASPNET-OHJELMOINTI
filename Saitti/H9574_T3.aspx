<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="H9574_T3.aspx.cs" Inherits="H9574_T3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="btnTestingConnection" Text="testikysely tietokantaan" runat="server" OnClick="btnTestingConnection_Click"/>
    <!-- astunnus -->
    <!-- asnimi -->
    <!-- yhteyshlo -->
    <!-- maa -->

    <asp:GridView ID="gvClients" runat="server" DataSourceID="" AllowSorting="True" >
        <Columns>
                
        </Columns>
    </asp:GridView>

</asp:Content>

