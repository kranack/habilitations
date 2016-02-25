<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<Habilitations.Models.User>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>User</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Nom) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nom) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.Prenom) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Prenom) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.DateNaissance) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DateNaissance) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.DateEntree) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DateEntree) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.ID }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
