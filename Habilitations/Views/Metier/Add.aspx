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
            Date de début du boulot
        </div>

        <input type="hidden" name="UserId" value="<%: Model.UserId %>" />

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
        <select id="metierId" name="MetierId">
            
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
                var metiers = [];
                $.each(data, function (id, categorie) {
                    console.log(categorie);
                    metiers[categorie.categorieId] = { categorieNom: categorie.categorieNom, metierId: categorie.id, metier: categorie.nom };
                    if ($("#categorie" + categorie.categorieId).length == 0) {
                        $("#metierId").append('<optgroup id="categorie' + categorie.categorieId + '" label="' + categorie.categorieNom + '"></optgroup>');
                    }
                    $("#categorie" + categorie.categorieId).append('<option value="' + categorie.id + '">' + categorie.nom + '</option>')
                    //$("#metierId").append('<option value="'+categorie.id+'">'+categorie.Nom+'</option>');
                });
            });
        });
    </script>
</asp:Content>
