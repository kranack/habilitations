<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Home page</h2>

<p><a href="/User/Signup">S'inscrire</a></p>

<p><a href="/User">Liste des utilisateurs</a></p>

<p><a href="/Metier">Ajouter un métier</a></p>

</asp:Content>
