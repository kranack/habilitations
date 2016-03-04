<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Add
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Add</h2>

    <% using (Html.BeginForm()) { %>
        <%: Html.AntiForgeryToken() %>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Role</legend>

            <input type="hidden" name="userId" value="<%: Model %>" />

            <div class="editor-label">
                Role
            </div>

            <select id="role" name="roleId">
                
            </select>
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>
    <% } %>
     
    <%: Html.ActionLink("Go to role list", "List", new { id = Model}) %>

     <script type="text/javascript">
        $(document).ready(function() {
            $.getJSON("/Role/Get", {}, function (data) {
                console.log(data);
                $.each(data, function (id, role) {
                    console.log(role);
                    $("#role").append('<option value="' + role.id + '">' + role.nom + '</option>');
                });
            });
        });
    </script>
</asp:Content>
