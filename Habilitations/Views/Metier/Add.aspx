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
            <%: Html.LabelFor(model => model.DebutJob) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DebutJob) %>
            <%: Html.ValidationMessageFor(model => model.DebutJob) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.FinJob) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.FinJob) %>
            <%: Html.ValidationMessageFor(model => model.FinJob) %>
        </div>

        <select name="metierId">
            <% foreach(Categorie categorie in Model) { %>
        
                <optgroup label="<%: categorie.Nom %>">
                    <% foreach(Metier metier in categorie.Metiers) { %>

                      <option value="<%: metier.ID %>"><%: metier.Nom %></option>

                    <% } %>
                </optgroup>

            <% } %>
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
                $.each(data, function (categorie) {
                    //
                });
            });
        });
    </script>
</asp:Content>
