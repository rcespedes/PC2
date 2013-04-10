<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebClient._Default" Debug="true" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   <h2>
        REST con WCF
    </h2>
    <p>
    URL: 
        <asp:TextBox ID="txtUrl" runat="server" Width="604px"></asp:TextBox>
    </p>
    <p>
    Metodh:
        <asp:TextBox ID="txtMetodo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Enviar" onclick="Button1_Click" />
    </p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server" Height="200px" TextMode="MultiLine" 
            Width="600px"></asp:TextBox>
    </p>
</asp:Content>
