<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Habilitations.Models.Role>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>List</h2>

     <table class="table">
        <tr>
             <th>
                Nom
            </th>
        </tr>
        <% foreach (var item in Model) { %>
            <tr>
                <td>
                    <%: Html.DisplayFor(modelItem => item.Nom) %>
                </td>
            </tr>
        <% } %>
    </table>

    <a href="/Metier">Back to user search</a>
</asp:Content>
