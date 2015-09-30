<%@ Page Title="Corporativo - Formulario Comercial" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="corporativo-form-comerc.aspx.cs" Inherits="WebApplication2.html.corporativo_form_comerc" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<h2>Corporativo - Formulario Comercial</h2>

<p><asp:HyperLink ID="id01" runat="server" NavigateUrl="~/corporativo/formulariosdts/comercial/nombre_documento.pdf" Target="_blank">CAMBIAR NOMBRE DOC</asp:HyperLink></p>

<%--recordar ir aumentando el ID en 1 cada vez que se agrega una linea.--%>



</asp:Content>
