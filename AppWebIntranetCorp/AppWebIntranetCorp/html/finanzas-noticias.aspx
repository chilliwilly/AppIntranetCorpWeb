﻿<%@ Page Title="Noticias Finanzas" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="finanzas-noticias.aspx.cs" Inherits="WebApplication2.html.finanzas_noticias" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<html>
<!--MODIFICAR SOLO LO QUE ESTA ENTRE EL TEXTO EN VERDE -->

<h2>Noticias Finanzas</h2>
<asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="705px" Height="400px" ReadOnly="true" Font-Bold="True" Font-Size="Medium">
31/03/2014
Texto de prueba.
Se implemento texto de prueba para esta pagina.

31/03/2014
Texto de prueba.
Se implemento texto de prueba para esta pagina.

</asp:TextBox>
<!--FIN SECCION MODIFICACION -->
</html>
</asp:Content>
