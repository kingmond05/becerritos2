<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Graficas.aspx.cs" Inherits="Dec_Becerritos_app.Graficas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <script type="text/javascript">
        <%= jscript %>
    </script>
<div class="Table_1">
<div id="DivG1">
<asp:TextBox ID="txtParse" TextMode="MultiLine" runat="server" Width="200px"></asp:TextBox>
<asp:Button ID="btnParse" runat="server" Text="Generar json" OnClick="json1_click"/>
</div>
</div>
</asp:Content>
