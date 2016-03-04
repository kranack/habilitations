<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Habilitations.Models.Job>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>List</h2>

    <table class="table">
        <tr>
             <th>
                Métier
            </th>

            <th>
                Date de début
            </th>

            <th>
                Date de fin
            </th>
        </tr>
        <% foreach (var item in Model) { %>
            <tr>
                <td>
                    <%: Html.DisplayFor(modelItem => item.Metier.Nom) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.DebutJob) %>
                </td>
                <td>
                    <%: Html.DisplayFor(modelItem => item.FinJob) %>
                </td>
            </tr>
        <% } %>
    </table>

    <%: Html.ActionLink("Back to user search", "Index") %>

</asp:Content>
