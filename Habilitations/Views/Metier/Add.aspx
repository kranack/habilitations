<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<Habilitations.Models.Job>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Add
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Add</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Metier</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DebutJob) %>
        </div>
        <div class="editor-field editor-uppercase">
            <%: @Html.EditorFor(model => model.DebutJob) 
            %>
            <%: Html.ValidationMessageFor(model => model.DebutJob) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.FinJob) %>
        </div>
        <div class="editor-field editor-capitalize">
            <%: Html.EditorFor(model => model.FinJob) %>
            <%: Html.ValidationMessageFor(model => model.FinJob) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

</asp:Content>
