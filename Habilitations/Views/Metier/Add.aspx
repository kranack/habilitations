<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
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

        <select>
            <% foreach(Categorie categorie in Model) { %>
        
                <optgroup label="<%: categorie.Nom %>">
                    <% foreach(Metier metier in categorie.Metiers) { %>

                      <option value="<%: metier.Nom %>"><%: metier.Nom %></option>

                    <% } %>
                </optgroup>

            <% } %>
        </select>
        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

</asp:Content>
