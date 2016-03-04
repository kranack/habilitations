<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<Habilitations.Models.User>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>User</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nom) %>
        </div>
        <div class="editor-field editor-uppercase">
            <%: @Html.EditorFor(model => model.Nom) %>
            <%: Html.ValidationMessageFor(model => model.Nom) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Prenom) %>
        </div>
        <div class="editor-field editor-capitalize">
            <%: Html.EditorFor(model => model.Prenom) %>
            <%: Html.ValidationMessageFor(model => model.Prenom) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DateNaissance) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DateNaissance) %>
            <%: Html.ValidationMessageFor(model => model.DateNaissance) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DateEntree) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DateEntree) %>
            <%: Html.ValidationMessageFor(model => model.DateEntree) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
