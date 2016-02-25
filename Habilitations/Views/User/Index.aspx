<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Habilitations.Models.User>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            <%: Html.DisplayNameFor(model => model.Nom) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.Prenom) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.DateNaissance) %>
        </th>
        <th>
            <%: Html.DisplayNameFor(model => model.DateEntree) %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nom) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Prenom) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DateNaissance) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DateEntree) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.ID }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.ID }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.ID }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
