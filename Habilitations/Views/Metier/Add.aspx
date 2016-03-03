<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<Habilitations.Models.Job>" %>
<%@ import namespace="Habilitations.Models" %>

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
            Métier
        </div>
        <div class="editor-field editor-uppercase">
           <select id="MetierId" name="MetierId"></select>
            <%: Html.ValidationMessageFor(model => model.MetierId) %>
        </div>

        <div class="editor-label">
            Date de début du boulot
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DebutJob) %>
            <%: Html.ValidationMessageFor(model => model.DebutJob) %>
        </div>

        <div class="editor-label">
            Date de fin du boulot
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.FinJob) %>
            <%: Html.ValidationMessageFor(model => model.FinJob) %>
        </div>

        <div class="editor-label">
            Métier
        </div>
        <select id="metierId" name="metierId">
            
        </select>
        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>
    <script type="text/javascript">
        $(document).ready(function() {
            $.getJSON("/Metier/Get", {}, function (data) {
                console.log(data);
                $.each(data, function (id, categorie) {
                    console.log(categorie);
                    $("#metierId").append('<option value="'+categorie.ID+'">'+categorie.Nom+'</option>');
                });
            });
        });
    </script>
</asp:Content>
