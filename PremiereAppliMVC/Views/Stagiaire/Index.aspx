<%@ Page Title="" Language="C#"
MasterPageFile="~/Views/Shared/Site.Master"
Inherits="System.Web.Mvc.ViewPage<IEnumerable<PremiereAppliMVC.Models.Personne.Stagiaire>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    GestionStagiaires
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Gestion des Stagiaires</h2>
    
    <table>
        <tr>
            <%--<th></th>--%>
            <th>
                Identifiant
            </th>
            <th>
                Nom
            </th>
            <th>
                Prenom
            </th>
        </tr>
        <% foreach (var item in Model) { %>
            <tr>
                <%--<td>
                    <%= Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> | <%= Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%>
                </td>--%>
                <td> 
                    <%= Html.Encode(item.Identifiant) %>
                </td>
                <td>
                    <%= Html.Encode(item.Nom) %>
                </td>
                <td>
                    <%= Html.Encode(item.Prenom) %>
                </td>
                <td>
                    <%= Html.ActionLink("Cours", "Index", "Cours", new { aIdentifiantStagiaire = item.Identifiant }, null)%>
                </td>
            </tr>
        <% } %>
    </table>
    <%--<p> <%= Html.ActionLink("Create New", "Create") %>
    </p>--%>
</asp:Content>