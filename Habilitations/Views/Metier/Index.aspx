<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Habilitations.Models.User>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

    <%  using (Html.BeginForm()){    %>
         <p> Title: <%: @Html.TextBox("SearchString") %> <br />   
         <input type="submit" value="Filter" /></p> 
     <%   } %>

    <table class="table">
        <tr>
             <th>
                Nom
            </th>

            <th>
                Prénom
            </th>

            <th>
                Date de naissance
            </th>

            <th>
                Date d'entrée en entreprise
            </th>
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
            </tr>
        <% } %>
    </table>
</asp:Content>
